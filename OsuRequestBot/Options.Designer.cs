namespace OsuRequestBot
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.PrefixBox = new DevExpress.XtraEditors.TextEdit();
            this.SaveBTN = new DevExpress.XtraEditors.SimpleButton();
            this.CancelBTN = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.FileBox = new DevExpress.XtraEditors.ButtonEdit();
            this.NowPlayingCheck = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.PrefixBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NowPlayingCheck.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl4.Location = new System.Drawing.Point(12, 44);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(127, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "The customisation for ORB";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(119, 25);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "ORB Options";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Message Prefix:";
            // 
            // PrefixBox
            // 
            this.PrefixBox.EditValue = "ORB";
            this.PrefixBox.Location = new System.Drawing.Point(12, 91);
            this.PrefixBox.Name = "PrefixBox";
            this.PrefixBox.Size = new System.Drawing.Size(145, 20);
            this.PrefixBox.TabIndex = 10;
            // 
            // SaveBTN
            // 
            this.SaveBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBTN.Location = new System.Drawing.Point(23, 212);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(64, 23);
            this.SaveBTN.TabIndex = 11;
            this.SaveBTN.Text = "&Save";
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBTN.Location = new System.Drawing.Point(93, 212);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(64, 23);
            this.CancelBTN.TabIndex = 12;
            this.CancelBTN.Text = "&Cancel";
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 117);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Title Output:";
            // 
            // FileBox
            // 
            this.FileBox.Location = new System.Drawing.Point(12, 136);
            this.FileBox.Name = "FileBox";
            this.FileBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.FileBox.Properties.ReadOnly = true;
            this.FileBox.Size = new System.Drawing.Size(145, 20);
            this.FileBox.TabIndex = 14;
            this.FileBox.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.FileBox_ButtonClick);
            // 
            // NowPlayingCheck
            // 
            this.NowPlayingCheck.EditValue = true;
            this.NowPlayingCheck.Location = new System.Drawing.Point(10, 162);
            this.NowPlayingCheck.Name = "NowPlayingCheck";
            this.NowPlayingCheck.Properties.Caption = "Enable Now Playing";
            this.NowPlayingCheck.Size = new System.Drawing.Size(147, 19);
            this.NowPlayingCheck.TabIndex = 16;
            // 
            // Options
            // 
            this.AcceptButton = this.SaveBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBTN;
            this.ClientSize = new System.Drawing.Size(169, 247);
            this.Controls.Add(this.NowPlayingCheck);
            this.Controls.Add(this.FileBox);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.PrefixBox);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.PrefixBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NowPlayingCheck.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton SaveBTN;
        private DevExpress.XtraEditors.SimpleButton CancelBTN;
        public DevExpress.XtraEditors.TextEdit PrefixBox;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.ButtonEdit FileBox;
        public DevExpress.XtraEditors.CheckEdit NowPlayingCheck;
    }
}