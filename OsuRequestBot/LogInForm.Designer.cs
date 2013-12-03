namespace OsuRequestBot
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.UsernameBox = new DevExpress.XtraEditors.TextEdit();
            this.LoginBTN = new DevExpress.XtraEditors.SimpleButton();
            this.PasswordBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(157, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Twitch Bot Login";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Username: ";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(70, 65);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(202, 20);
            this.UsernameBox.TabIndex = 1;
            // 
            // LoginBTN
            // 
            this.LoginBTN.Location = new System.Drawing.Point(197, 117);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(75, 23);
            this.LoginBTN.TabIndex = 3;
            this.LoginBTN.Text = "&Log In";
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(70, 91);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Properties.UseSystemPasswordChar = true;
            this.PasswordBox.Size = new System.Drawing.Size(202, 20);
            this.PasswordBox.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Password: ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl4.Location = new System.Drawing.Point(13, 45);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(187, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "The login information for the twitch bot";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 127);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(111, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Get my IRC password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LogInForm
            // 
            this.AcceptButton = this.LoginBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 148);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInForm";
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.UsernameBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton LoginBTN;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.TextEdit UsernameBox;
        public DevExpress.XtraEditors.TextEdit PasswordBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}