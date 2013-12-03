using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace OsuRequestBot
{
    public partial class LogInForm : DevExpress.XtraEditors.XtraForm
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://twitchapps.com/tmi/");
        }
    }
}