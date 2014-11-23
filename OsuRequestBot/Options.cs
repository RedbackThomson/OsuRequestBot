using System;
using System.Windows.Forms;

namespace OsuRequestBot
{
    public partial class Options : DevExpress.XtraEditors.XtraForm
    {
        public Options()
        {
            InitializeComponent();
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void FileBox_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
                {
                    FileName = "OsuTitle.txt",
                    CheckPathExists = true,
                    Filter = "Text File|*.txt",
                    Title = "Song Name Output File"
                };
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
            }
        }
    }
}