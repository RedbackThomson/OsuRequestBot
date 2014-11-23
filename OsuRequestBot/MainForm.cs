using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;


namespace OsuRequestBot
{
    public partial class MainForm : XtraForm
    {
        public static string OutputFile = @"C:\SongTitle.txt";
        public string CurrentSong = "";

        private string _username = "", _password = "";
        private ChatBot _bot;
        private readonly List<RequestGridItem> _requests = new List<RequestGridItem>();
        private Thread _updateThread;
        private bool _running = false;

        public MainForm()
        {
            InitializeComponent();
            RequestGrid.DataSource = _requests;
            UpdateRequestFile();
            LoadSettings();
            CreateConnectPopup();
        }

        public void CreateConnectPopup()
        {
            DXPopupMenu popupMenu = new DXPopupMenu();
            popupMenu.Items.Add(new DXMenuItem("Log Out", ResetLogin));
            ConnectBTN.DropDownControl = popupMenu;
        }

        public void ResetLogin(object sender, EventArgs e)
        {
            _username = "";
            _password = "";
            LogIn();
        }

        public void AddRequest(RequestGridItem item)
        {
            _requests.Add(item);
            RequestGrid.RefreshDataSource();
            UpdateRequestFile();
        }

        public void UpdateRequestFile()
        {
            if (!System.IO.Directory.Exists("titles")) System.IO.Directory.CreateDirectory("titles");
            System.IO.File.WriteAllText("titles/request_count.txt", _requests.Count.ToString());
        }

        private void UpdateList()
        {
            string osuTitle = "";
            while (true)
            {
                try
                {
                    var processSearch = Process.GetProcessesByName("osu!");
                    if (processSearch.Length < 1)
                        throw new Exception("No Osu! Found");
                    var osuProcess = processSearch[0];

                    var title = osuProcess.MainWindowTitle;
                    if (title != "osu!")
                    {
                        var formattedTitle = FormatTitle(title);
                        if (osuTitle != formattedTitle)
                        {
                            NewTitle(formattedTitle);
                            osuTitle = formattedTitle;
                            SetCurrentLabel(formattedTitle);
                        }
                    }
                    else
                    {
                        if (osuTitle != "")
                        {
                            osuTitle = "";
                            SetCurrentLabel("");
                        }
                    }
                }
                catch (Exception)
                {

                }
                Thread.Sleep(1000);
            }
        }

        private void SetCurrentLabel(string newCurrent)
        {
            if (CurrentLabel.InvokeRequired)
                CurrentLabel.Invoke(new MethodInvoker(() => SetCurrentLabel(newCurrent)));
            else
                CurrentLabel.Text = string.Format("Current Song: {0}", newCurrent);
        }

        private void NewTitle(string newTitle)
        {
            CurrentSong = newTitle;
            List<RequestGridItem> toDelete = new List<RequestGridItem>();
            foreach (var song in _requests)
                if (newTitle.Contains(song.Song))
                {
                    toDelete.Add(song);
                    break;
                }
            if (toDelete.Count == 0) return;
            foreach(var song in toDelete) _requests.Remove(song);
            RequestGrid.RefreshDataSource();
            UpdateRequestFile();
        }

        private static string FormatTitle(string title)
        {
            var currentTitle = title.Replace("osu!  -", "");
            currentTitle = currentTitle.Substring(0, currentTitle.LastIndexOf('[')).Trim();
            return currentTitle;
        }

        private bool LogIn()
        {
            LogInForm loginForm = new LogInForm();
            if (loginForm.ShowDialog() != DialogResult.OK) return false;

            _username = loginForm.UsernameBox.Text;
            _password = loginForm.PasswordBox.Text;

            SaveSettings();

            return (!(string.IsNullOrEmpty(_username) || string.IsNullOrEmpty(_password)));
        }

        private void RequestView_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if(e.Column.FieldName == "Link")
                Process.Start(e.CellValue.ToString());
            else if(e.Column.FieldName == "Website")
                Process.Start(e.CellValue.ToString());
        }

        private void ConnectBTN_Click(object sender, EventArgs e)
        {
            if (!_running)
            {
                if (string.IsNullOrEmpty(_username) || string.IsNullOrEmpty(_password))
                    if (!LogIn()) return;

                //Set up bot
                _bot = new ChatBot(ChannelBox.Text);
                Commands.SetRequests(this);

                _bot.SetBotAccountInfo(_username, _password);
                if(_bot.StartBot())
                {
                    //Start Updating Process
                    _updateThread = new Thread(UpdateList);
                    _updateThread.Start();
                    ConnectBTN.Text = "Disconnect";

                    _running = true;      
                }
                else
                {
                    MessageBox.Show("Could not log in to the IRC server. Please check your login information.", "Connection Issue");
                }
            }
            else
            {
                _updateThread.Abort();
                _bot.StopBot();

                ConnectBTN.Text = "Connect";
                _running = false;
            }
        }

        private void SaveSettings()
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("OsuRequest");
            key.SetValue("Username", _username);
            key.SetValue("Password", _password);

            var optionsKey = key.CreateSubKey("Options");
            optionsKey.SetValue("Prefix", ChatBot.Prefix);
            optionsKey.SetValue("NowPlaying", Commands.AllowNowPlaying);
            key.Close();
        }

        private void LoadSettings()
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("OsuRequest");
            _username = (string) key.GetValue("Username");
            _password = (string) key.GetValue("Password");

            var optionsKey = key.CreateSubKey("Options");
            ChatBot.Prefix = (!string.IsNullOrEmpty((string) optionsKey.GetValue("Prefix")) ? (string) optionsKey.GetValue("Prefix") : "ORB");
            Commands.AllowNowPlaying = bool.Parse((string)optionsKey.GetValue("NowPlaying", "True"));
            key.Close();
        }

        private void RequestGrid_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            var view = (sender as GridControl).FocusedView as GridView;
            if(e.KeyCode == Keys.Delete)
            {
                view.DeleteSelectedRows();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_running)
                ConnectBTN_Click(sender, e);
        }

        private void CreditLabel_Click(object sender, EventArgs e)
        {
            Process.Start("http://osu.ppy.sh/u/Redback93");
        }

        private void OptionsBTN_Click(object sender, EventArgs e)
        {
            var optionsDialog = new Options {PrefixBox = {Text = ChatBot.Prefix}, NowPlayingCheck = {Checked = Commands.AllowNowPlaying}};

            if (optionsDialog.ShowDialog() == DialogResult.OK)
            {
                ChatBot.Prefix = optionsDialog.PrefixBox.Text;
                Commands.AllowNowPlaying = optionsDialog.NowPlayingCheck.Checked;
                SaveSettings();
            }
        }
    }

    public class RequestGridItem
    {
        public DateTime RequestDate { get; set; }
        public string User { get; set; }
        public bool Ranked { get; set; }
        public string Artist { get; set; }
        public string Creator { get; set; }
        public string Difficulty { get; set; }
        public string Song { get; set; }
        public string Link { get; set; }
        public string Website { get; set; }
        public string Mods { get; set; }
    }
}