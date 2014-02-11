namespace OsuRequestBot
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ChannelBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.requestGridItemBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.RequestView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRequestDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtist = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMods = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RequestGrid = new DevExpress.XtraGrid.GridControl();
            this.requestGridItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CurrentLabel = new DevExpress.XtraEditors.LabelControl();
            this.ConnectBTN = new DevExpress.XtraEditors.DropDownButton();
            this.CreditLabel = new DevExpress.XtraEditors.LabelControl();
            this.TitleLabel = new DevExpress.XtraEditors.LabelControl();
            this.OptionsBTN = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestGridItemBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestGridItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ChannelBox
            // 
            this.ChannelBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChannelBox.EditValue = "";
            this.ChannelBox.Location = new System.Drawing.Point(146, 15);
            this.ChannelBox.Name = "ChannelBox";
            this.ChannelBox.Size = new System.Drawing.Size(534, 20);
            this.ChannelBox.TabIndex = 1;
            this.ChannelBox.ToolTip = "Just the username of the Twitch tv channel (eg. Redback93)";
            this.ChannelBox.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Twitch Channel Username:";
            // 
            // requestGridItemBindingSource3
            // 
            this.requestGridItemBindingSource3.DataSource = typeof(OsuRequestBot.RequestGridItem);
            // 
            // RequestView
            // 
            this.RequestView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRequestDate,
            this.colUser,
            this.colArtist,
            this.gridColumn1,
            this.colSong,
            this.colLink,
            this.colMods,
            this.gridColumn2,
            this.gridColumn3});
            this.RequestView.GridControl = this.RequestGrid;
            this.RequestView.Name = "RequestView";
            this.RequestView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.RequestView.OptionsBehavior.Editable = false;
            this.RequestView.OptionsBehavior.ReadOnly = true;
            this.RequestView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.RequestView.OptionsView.ShowGroupPanel = false;
            this.RequestView.OptionsView.ShowIndicator = false;
            this.RequestView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.RequestView_RowCellClick);
            // 
            // colRequestDate
            // 
            this.colRequestDate.Caption = "Date";
            this.colRequestDate.FieldName = "RequestDate";
            this.colRequestDate.Name = "colRequestDate";
            this.colRequestDate.Visible = true;
            this.colRequestDate.VisibleIndex = 0;
            this.colRequestDate.Width = 58;
            // 
            // colUser
            // 
            this.colUser.Caption = "Requester";
            this.colUser.FieldName = "User";
            this.colUser.Name = "colUser";
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 1;
            this.colUser.Width = 70;
            // 
            // colArtist
            // 
            this.colArtist.FieldName = "Artist";
            this.colArtist.Name = "colArtist";
            this.colArtist.Visible = true;
            this.colArtist.VisibleIndex = 3;
            this.colArtist.Width = 67;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Creator";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 56;
            // 
            // colSong
            // 
            this.colSong.FieldName = "Song";
            this.colSong.Name = "colSong";
            this.colSong.Visible = true;
            this.colSong.VisibleIndex = 6;
            this.colSong.Width = 239;
            // 
            // colLink
            // 
            this.colLink.Caption = "osu!Direct";
            this.colLink.FieldName = "Link";
            this.colLink.Name = "colLink";
            this.colLink.Visible = true;
            this.colLink.VisibleIndex = 7;
            this.colLink.Width = 115;
            // 
            // colMods
            // 
            this.colMods.FieldName = "Mods";
            this.colMods.Name = "colMods";
            this.colMods.Visible = true;
            this.colMods.VisibleIndex = 8;
            this.colMods.Width = 65;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Difficulty";
            this.gridColumn2.FieldName = "Difficulty";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 56;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ranked";
            this.gridColumn3.FieldName = "Ranked";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 54;
            // 
            // RequestGrid
            // 
            this.RequestGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestGrid.DataSource = this.requestGridItemBindingSource;
            this.RequestGrid.Location = new System.Drawing.Point(12, 68);
            this.RequestGrid.MainView = this.RequestView;
            this.RequestGrid.Name = "RequestGrid";
            this.RequestGrid.Size = new System.Drawing.Size(782, 289);
            this.RequestGrid.TabIndex = 3;
            this.RequestGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.RequestView});
            this.RequestGrid.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.RequestGrid_PreviewKeyDown);
            // 
            // requestGridItemBindingSource
            // 
            this.requestGridItemBindingSource.DataSource = typeof(OsuRequestBot.RequestGridItem);
            // 
            // CurrentLabel
            // 
            this.CurrentLabel.Location = new System.Drawing.Point(12, 49);
            this.CurrentLabel.Name = "CurrentLabel";
            this.CurrentLabel.Size = new System.Drawing.Size(68, 13);
            this.CurrentLabel.TabIndex = 5;
            this.CurrentLabel.Text = "Current Song:";
            // 
            // ConnectBTN
            // 
            this.ConnectBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectBTN.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.SplitButton;
            this.ConnectBTN.Location = new System.Drawing.Point(686, 12);
            this.ConnectBTN.Name = "ConnectBTN";
            this.ConnectBTN.Size = new System.Drawing.Size(108, 23);
            this.ConnectBTN.TabIndex = 6;
            this.ConnectBTN.Text = "&Connect";
            this.ConnectBTN.Click += new System.EventHandler(this.ConnectBTN_Click);
            // 
            // CreditLabel
            // 
            this.CreditLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditLabel.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.CreditLabel.Location = new System.Drawing.Point(684, 357);
            this.CreditLabel.Name = "CreditLabel";
            this.CreditLabel.Size = new System.Drawing.Size(110, 13);
            this.CreditLabel.TabIndex = 7;
            this.CreditLabel.Text = "Created by Redback93";
            this.CreditLabel.Click += new System.EventHandler(this.CreditLabel_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.TitleLabel.Location = new System.Drawing.Point(12, 357);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(81, 13);
            this.TitleLabel.TabIndex = 8;
            this.TitleLabel.Text = "Osu Request Bot";
            // 
            // OptionsBTN
            // 
            this.OptionsBTN.Location = new System.Drawing.Point(719, 41);
            this.OptionsBTN.Name = "OptionsBTN";
            this.OptionsBTN.Size = new System.Drawing.Size(75, 23);
            this.OptionsBTN.TabIndex = 9;
            this.OptionsBTN.Text = "&Options";
            this.OptionsBTN.Click += new System.EventHandler(this.OptionsBTN_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 369);
            this.Controls.Add(this.OptionsBTN);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CreditLabel);
            this.Controls.Add(this.ConnectBTN);
            this.Controls.Add(this.CurrentLabel);
            this.Controls.Add(this.RequestGrid);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ChannelBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ORB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ChannelBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestGridItemBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestGridItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit ChannelBox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource requestGridItemBindingSource3;
        private DevExpress.XtraGrid.Views.Grid.GridView RequestView;
        private DevExpress.XtraGrid.GridControl RequestGrid;
        private DevExpress.XtraEditors.LabelControl CurrentLabel;
        private DevExpress.XtraEditors.DropDownButton ConnectBTN;
        private DevExpress.XtraEditors.LabelControl CreditLabel;
        private DevExpress.XtraEditors.LabelControl TitleLabel;
        private DevExpress.XtraEditors.SimpleButton OptionsBTN;
        private DevExpress.XtraGrid.Columns.GridColumn colRequestDate;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraGrid.Columns.GridColumn colArtist;
        private DevExpress.XtraGrid.Columns.GridColumn colSong;
        private DevExpress.XtraGrid.Columns.GridColumn colLink;
        private DevExpress.XtraGrid.Columns.GridColumn colMods;
        private System.Windows.Forms.BindingSource requestGridItemBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;


    }
}
