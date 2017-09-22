namespace ABCAddressBook
{
    partial class MessageHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageHistoryForm));
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ReceivedTab = new System.Windows.Forms.TabPage();
            this.ReceivedList = new System.Windows.Forms.ListView();
            this.FromHeader = new System.Windows.Forms.ColumnHeader();
            this.DateTimeHeader = new System.Windows.Forms.ColumnHeader();
            this.UrgentHeader = new System.Windows.Forms.ColumnHeader();
            this.DetailsHeader = new System.Windows.Forms.ColumnHeader();
            this.SentTab = new System.Windows.Forms.TabPage();
            this.SentList = new System.Windows.Forms.ListView();
            this.ToHeader = new System.Windows.Forms.ColumnHeader();
            this.DateTimeSentHeader = new System.Windows.Forms.ColumnHeader();
            this.ReadHeader = new System.Windows.Forms.ColumnHeader();
            this.DetailsSentHeader = new System.Windows.Forms.ColumnHeader();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.MainToolStrip.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.ReceivedTab.SuspendLayout();
            this.SentTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshButton,
            this.CloseButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(674, 44);
            this.MainToolStrip.TabIndex = 0;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(49, 41);
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(37, 41);
            this.CloseButton.Text = "Close";
            this.CloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.ReceivedTab);
            this.MainTabControl.Controls.Add(this.SentTab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 44);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.Padding = new System.Drawing.Point(0, 0);
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(674, 323);
            this.MainTabControl.TabIndex = 1;
            // 
            // ReceivedTab
            // 
            this.ReceivedTab.Controls.Add(this.ReceivedList);
            this.ReceivedTab.Location = new System.Drawing.Point(4, 22);
            this.ReceivedTab.Margin = new System.Windows.Forms.Padding(0);
            this.ReceivedTab.Name = "ReceivedTab";
            this.ReceivedTab.Size = new System.Drawing.Size(666, 297);
            this.ReceivedTab.TabIndex = 1;
            this.ReceivedTab.Text = "Received";
            this.ReceivedTab.UseVisualStyleBackColor = true;
            // 
            // ReceivedList
            // 
            this.ReceivedList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FromHeader,
            this.DateTimeHeader,
            this.UrgentHeader,
            this.DetailsHeader});
            this.ReceivedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReceivedList.FullRowSelect = true;
            this.ReceivedList.GridLines = true;
            this.ReceivedList.Location = new System.Drawing.Point(0, 0);
            this.ReceivedList.Name = "ReceivedList";
            this.ReceivedList.Size = new System.Drawing.Size(666, 297);
            this.ReceivedList.SmallImageList = this.ImageList;
            this.ReceivedList.TabIndex = 0;
            this.ReceivedList.UseCompatibleStateImageBehavior = false;
            this.ReceivedList.View = System.Windows.Forms.View.Details;
            this.ReceivedList.DoubleClick += new System.EventHandler(this.ReceivedList_DoubleClick);
            // 
            // FromHeader
            // 
            this.FromHeader.Text = "From";
            this.FromHeader.Width = 120;
            // 
            // DateTimeHeader
            // 
            this.DateTimeHeader.Text = "Date / Time";
            this.DateTimeHeader.Width = 130;
            // 
            // UrgentHeader
            // 
            this.UrgentHeader.Text = "Urgent";
            // 
            // DetailsHeader
            // 
            this.DetailsHeader.Text = "Details";
            this.DetailsHeader.Width = 400;
            // 
            // SentTab
            // 
            this.SentTab.Controls.Add(this.SentList);
            this.SentTab.Location = new System.Drawing.Point(4, 22);
            this.SentTab.Margin = new System.Windows.Forms.Padding(0);
            this.SentTab.Name = "SentTab";
            this.SentTab.Size = new System.Drawing.Size(666, 297);
            this.SentTab.TabIndex = 0;
            this.SentTab.Text = "Sent";
            this.SentTab.UseVisualStyleBackColor = true;
            // 
            // SentList
            // 
            this.SentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ToHeader,
            this.DateTimeSentHeader,
            this.ReadHeader,
            this.DetailsSentHeader});
            this.SentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SentList.FullRowSelect = true;
            this.SentList.GridLines = true;
            this.SentList.Location = new System.Drawing.Point(0, 0);
            this.SentList.Name = "SentList";
            this.SentList.Size = new System.Drawing.Size(666, 297);
            this.SentList.SmallImageList = this.ImageList;
            this.SentList.TabIndex = 0;
            this.SentList.UseCompatibleStateImageBehavior = false;
            this.SentList.View = System.Windows.Forms.View.Details;
            this.SentList.DoubleClick += new System.EventHandler(this.SentList_DoubleClick);
            // 
            // ToHeader
            // 
            this.ToHeader.Text = "To";
            this.ToHeader.Width = 120;
            // 
            // DateTimeSentHeader
            // 
            this.DateTimeSentHeader.Text = "Date / Time";
            this.DateTimeSentHeader.Width = 130;
            // 
            // ReadHeader
            // 
            this.ReadHeader.Text = "Read";
            // 
            // DetailsSentHeader
            // 
            this.DetailsSentHeader.Text = "Details";
            this.DetailsSentHeader.Width = 400;
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "MAIL02A.ICO");
            this.ImageList.Images.SetKeyName(1, "MAIL01A.ICO");
            // 
            // MessageHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 367);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.MainToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message History";
            this.Load += new System.EventHandler(this.MessageHistoryForm_Load);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.ReceivedTab.ResumeLayout(false);
            this.SentTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton CloseButton;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage SentTab;
        private System.Windows.Forms.TabPage ReceivedTab;
        private System.Windows.Forms.ListView SentList;
        private System.Windows.Forms.ListView ReceivedList;
        private System.Windows.Forms.ColumnHeader FromHeader;
        private System.Windows.Forms.ColumnHeader DateTimeHeader;
        private System.Windows.Forms.ColumnHeader UrgentHeader;
        private System.Windows.Forms.ColumnHeader DetailsHeader;
        private System.Windows.Forms.ColumnHeader ToHeader;
        private System.Windows.Forms.ColumnHeader DateTimeSentHeader;
        private System.Windows.Forms.ColumnHeader ReadHeader;
        private System.Windows.Forms.ColumnHeader DetailsSentHeader;
        private System.Windows.Forms.ImageList ImageList;
    }
}