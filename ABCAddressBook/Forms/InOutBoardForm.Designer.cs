namespace ABCAddressBook
{
    partial class InOutBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InOutBoardForm));
            this.InOutToolStrip = new System.Windows.Forms.ToolStrip();
            this.InButton = new System.Windows.Forms.ToolStripSplitButton();
            this.setStartTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OutButton = new System.Windows.Forms.ToolStripSplitButton();
            this.AwayButton = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.StaffList = new System.Windows.Forms.ListView();
            this.NameHeader = new System.Windows.Forms.ColumnHeader();
            this.StatusHeader = new System.Windows.Forms.ColumnHeader();
            this.DateTimeHeader = new System.Windows.Forms.ColumnHeader();
            this.ReasonHeader = new System.Windows.Forms.ColumnHeader();
            this.StartTimeHeader = new System.Windows.Forms.ColumnHeader();
            this.InOutToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // InOutToolStrip
            // 
            this.InOutToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InButton,
            this.OutButton,
            this.AwayButton,
            this.toolStripSeparator1,
            this.AddButton,
            this.DeleteButton});
            this.InOutToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.InOutToolStrip.Location = new System.Drawing.Point(0, 0);
            this.InOutToolStrip.Name = "InOutToolStrip";
            this.InOutToolStrip.Size = new System.Drawing.Size(773, 44);
            this.InOutToolStrip.TabIndex = 0;
            // 
            // InButton
            // 
            this.InButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setStartTimeToolStripMenuItem});
            this.InButton.Image = ((System.Drawing.Image)(resources.GetObject("InButton.Image")));
            this.InButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.InButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InButton.Name = "InButton";
            this.InButton.Size = new System.Drawing.Size(40, 41);
            this.InButton.Text = "In";
            this.InButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.InButton.ToolTipText = "In";
            this.InButton.ButtonClick += new System.EventHandler(this.InButton_ButtonClick);
            // 
            // setStartTimeToolStripMenuItem
            // 
            this.setStartTimeToolStripMenuItem.Name = "setStartTimeToolStripMenuItem";
            this.setStartTimeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.setStartTimeToolStripMenuItem.Tag = "test";
            this.setStartTimeToolStripMenuItem.Text = "Set Start Time";
            this.setStartTimeToolStripMenuItem.Click += new System.EventHandler(this.setStartTimeToolStripMenuItem_Click);
            // 
            // OutButton
            // 
            this.OutButton.Image = ((System.Drawing.Image)(resources.GetObject("OutButton.Image")));
            this.OutButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OutButton.Name = "OutButton";
            this.OutButton.Size = new System.Drawing.Size(41, 41);
            this.OutButton.Text = "Out";
            this.OutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OutButton.ToolTipText = "Out";
            this.OutButton.ButtonClick += new System.EventHandler(this.OutButton_ButtonClick);
            // 
            // AwayButton
            // 
            this.AwayButton.Image = ((System.Drawing.Image)(resources.GetObject("AwayButton.Image")));
            this.AwayButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AwayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AwayButton.Name = "AwayButton";
            this.AwayButton.Size = new System.Drawing.Size(50, 41);
            this.AwayButton.Text = "Away";
            this.AwayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AwayButton.ToolTipText = "Away";
            this.AwayButton.ButtonClick += new System.EventHandler(this.AwayButton_ButtonClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // AddButton
            // 
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(60, 41);
            this.AddButton.Text = "Add Name";
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(42, 41);
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // StaffList
            // 
            this.StaffList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.StatusHeader,
            this.DateTimeHeader,
            this.ReasonHeader,
            this.StartTimeHeader});
            this.StaffList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffList.FullRowSelect = true;
            this.StaffList.GridLines = true;
            this.StaffList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.StaffList.Location = new System.Drawing.Point(0, 44);
            this.StaffList.MultiSelect = false;
            this.StaffList.Name = "StaffList";
            this.StaffList.ShowGroups = false;
            this.StaffList.Size = new System.Drawing.Size(773, 503);
            this.StaffList.TabIndex = 1;
            this.StaffList.UseCompatibleStateImageBehavior = false;
            this.StaffList.View = System.Windows.Forms.View.Details;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 150;
            // 
            // StatusHeader
            // 
            this.StatusHeader.Text = "Status";
            this.StatusHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DateTimeHeader
            // 
            this.DateTimeHeader.Text = "Date/Time";
            this.DateTimeHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateTimeHeader.Width = 150;
            // 
            // ReasonHeader
            // 
            this.ReasonHeader.Text = "Reason";
            this.ReasonHeader.Width = 400;
            // 
            // StartTimeHeader
            // 
            this.StartTimeHeader.Text = "Start Time";
            this.StartTimeHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartTimeHeader.Width = 150;
            // 
            // InOutBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 547);
            this.ControlBox = false;
            this.Controls.Add(this.StaffList);
            this.Controls.Add(this.InOutToolStrip);
            this.Name = "InOutBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In / Out Board";
            this.Load += new System.EventHandler(this.InOutBoardForm_Load);
            this.InOutToolStrip.ResumeLayout(false);
            this.InOutToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip InOutToolStrip;
        private System.Windows.Forms.ListView StaffList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton AddButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripSplitButton InButton;
        private System.Windows.Forms.ToolStripSplitButton AwayButton;
        private System.Windows.Forms.ToolStripSplitButton OutButton;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader StatusHeader;
        private System.Windows.Forms.ColumnHeader DateTimeHeader;
        private System.Windows.Forms.ColumnHeader ReasonHeader;
        private System.Windows.Forms.ToolStripMenuItem setStartTimeToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader StartTimeHeader;
    }
}