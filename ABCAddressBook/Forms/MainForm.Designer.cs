namespace ABCAddressBook
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCategoriesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databasePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MinimiseStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartupStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whosOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printAddressBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.ContactsButton = new System.Windows.Forms.ToolStripButton();
            this.InOutButton = new System.Windows.Forms.ToolStripButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.IconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMessageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.messageHistoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuMain.SuspendLayout();
            this.toolMain.SuspendLayout();
            this.IconMenu.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.messagingToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(0);
            this.menuMain.Size = new System.Drawing.Size(630, 24);
            this.menuMain.TabIndex = 3;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditCategoriesMenuItem,
            this.databasePropertiesToolStripMenuItem,
            this.programSettingsToolStripMenuItem,
            this.whosOnlineToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.printAddressBookToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.fileToolStripMenuItem.Text = "&Database";
            // 
            // EditCategoriesMenuItem
            // 
            this.EditCategoriesMenuItem.Name = "EditCategoriesMenuItem";
            this.EditCategoriesMenuItem.ShortcutKeyDisplayString = "E";
            this.EditCategoriesMenuItem.Size = new System.Drawing.Size(197, 22);
            this.EditCategoriesMenuItem.Text = "&Edit Categories";
            this.EditCategoriesMenuItem.Click += new System.EventHandler(this.EditCategoriesMenuItem_Click);
            // 
            // databasePropertiesToolStripMenuItem
            // 
            this.databasePropertiesToolStripMenuItem.Name = "databasePropertiesToolStripMenuItem";
            this.databasePropertiesToolStripMenuItem.ShortcutKeyDisplayString = "D";
            this.databasePropertiesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.databasePropertiesToolStripMenuItem.Text = "&Database Properties";
            this.databasePropertiesToolStripMenuItem.Click += new System.EventHandler(this.databasePropertiesToolStripMenuItem_Click);
            // 
            // programSettingsToolStripMenuItem
            // 
            this.programSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MinimiseStripMenuItem,
            this.StartupStripMenuItem});
            this.programSettingsToolStripMenuItem.Name = "programSettingsToolStripMenuItem";
            this.programSettingsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.programSettingsToolStripMenuItem.Text = "&Program Settings";
            // 
            // MinimiseStripMenuItem
            // 
            this.MinimiseStripMenuItem.Checked = true;
            this.MinimiseStripMenuItem.CheckOnClick = true;
            this.MinimiseStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MinimiseStripMenuItem.Name = "MinimiseStripMenuItem";
            this.MinimiseStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.MinimiseStripMenuItem.Text = "&Minimise on Start";
            this.MinimiseStripMenuItem.CheckedChanged += new System.EventHandler(this.MinimiseStripMenuItem_CheckedChanged);
            // 
            // StartupStripMenuItem
            // 
            this.StartupStripMenuItem.Checked = true;
            this.StartupStripMenuItem.CheckOnClick = true;
            this.StartupStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StartupStripMenuItem.Name = "StartupStripMenuItem";
            this.StartupStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.StartupStripMenuItem.Text = "&Start on Windows Startup";
            this.StartupStripMenuItem.CheckedChanged += new System.EventHandler(this.StartupStripMenuItem_CheckedChanged);
            // 
            // whosOnlineToolStripMenuItem
            // 
            this.whosOnlineToolStripMenuItem.Name = "whosOnlineToolStripMenuItem";
            this.whosOnlineToolStripMenuItem.ShortcutKeyDisplayString = "W";
            this.whosOnlineToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.whosOnlineToolStripMenuItem.Text = "&Who\'s Online";
            this.whosOnlineToolStripMenuItem.Click += new System.EventHandler(this.whosOnlineToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeyDisplayString = "P";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.exportToolStripMenuItem.Text = "Ex&port Data";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // printAddressBookToolStripMenuItem
            // 
            this.printAddressBookToolStripMenuItem.Name = "printAddressBookToolStripMenuItem";
            this.printAddressBookToolStripMenuItem.ShortcutKeyDisplayString = "A";
            this.printAddressBookToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.printAddressBookToolStripMenuItem.Text = "Print &Address Book";
            this.printAddressBookToolStripMenuItem.Click += new System.EventHandler(this.printAddressBookToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(194, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "X";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // messagingToolStripMenuItem
            // 
            this.messagingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendMessageToolStripMenuItem,
            this.messageHistoryToolStripMenuItem});
            this.messagingToolStripMenuItem.Name = "messagingToolStripMenuItem";
            this.messagingToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.messagingToolStripMenuItem.Text = "&Messaging";
            // 
            // sendMessageToolStripMenuItem
            // 
            this.sendMessageToolStripMenuItem.Name = "sendMessageToolStripMenuItem";
            this.sendMessageToolStripMenuItem.ShortcutKeyDisplayString = "S";
            this.sendMessageToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.sendMessageToolStripMenuItem.Text = "&Send Message";
            this.sendMessageToolStripMenuItem.Click += new System.EventHandler(this.sendMessageToolStripMenuItem_Click);
            // 
            // messageHistoryToolStripMenuItem
            // 
            this.messageHistoryToolStripMenuItem.Name = "messageHistoryToolStripMenuItem";
            this.messageHistoryToolStripMenuItem.ShortcutKeyDisplayString = "H";
            this.messageHistoryToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.messageHistoryToolStripMenuItem.Text = "Message &History";
            this.messageHistoryToolStripMenuItem.Click += new System.EventHandler(this.messageHistoryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.RegisterToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeyDisplayString = "C";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            this.contentsToolStripMenuItem.Click += new System.EventHandler(this.contentsToolStripMenuItem_Click);
            // 
            // RegisterToolStripMenuItem
            // 
            this.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem";
            this.RegisterToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.RegisterToolStripMenuItem.Text = "Register";
            this.RegisterToolStripMenuItem.Click += new System.EventHandler(this.RegisterToolStripMenuItem_Click);
            // 
            // toolMain
            // 
            this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContactsButton,
            this.InOutButton});
            this.toolMain.Location = new System.Drawing.Point(0, 24);
            this.toolMain.Name = "toolMain";
            this.toolMain.Size = new System.Drawing.Size(630, 44);
            this.toolMain.TabIndex = 4;
            // 
            // ContactsButton
            // 
            this.ContactsButton.Image = ((System.Drawing.Image)(resources.GetObject("ContactsButton.Image")));
            this.ContactsButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ContactsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ContactsButton.Name = "ContactsButton";
            this.ContactsButton.Size = new System.Drawing.Size(54, 41);
            this.ContactsButton.Text = "Contacts";
            this.ContactsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ContactsButton.Click += new System.EventHandler(this.ContactsButton_Click);
            // 
            // InOutButton
            // 
            this.InOutButton.Image = ((System.Drawing.Image)(resources.GetObject("InOutButton.Image")));
            this.InOutButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.InOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InOutButton.Name = "InOutButton";
            this.InOutButton.Size = new System.Drawing.Size(74, 41);
            this.InOutButton.Text = "In/Out Board";
            this.InOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.InOutButton.Click += new System.EventHandler(this.InOutButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "ABC Address Book is running double click to open or right click for menu.";
            this.notifyIcon.BalloonTipTitle = "ABC Address Book";
            this.notifyIcon.ContextMenuStrip = this.IconMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "ABC Address Book";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // IconMenu
            // 
            this.IconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.sendMessageToolStripMenuItem1,
            this.messageHistoryToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.IconMenu.Name = "IconMenu";
            this.IconMenu.Size = new System.Drawing.Size(180, 92);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "O";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // sendMessageToolStripMenuItem1
            // 
            this.sendMessageToolStripMenuItem1.Name = "sendMessageToolStripMenuItem1";
            this.sendMessageToolStripMenuItem1.ShortcutKeyDisplayString = "S";
            this.sendMessageToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.sendMessageToolStripMenuItem1.Text = "&Send Message";
            this.sendMessageToolStripMenuItem1.Click += new System.EventHandler(this.sendMessageToolStripMenuItem_Click);
            // 
            // messageHistoryToolStripMenuItem1
            // 
            this.messageHistoryToolStripMenuItem1.Name = "messageHistoryToolStripMenuItem1";
            this.messageHistoryToolStripMenuItem1.ShortcutKeyDisplayString = "M";
            this.messageHistoryToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.messageHistoryToolStripMenuItem1.Text = "&Message History";
            this.messageHistoryToolStripMenuItem1.Click += new System.EventHandler(this.messageHistoryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeyDisplayString = "E";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUserName});
            this.statusStripMain.Location = new System.Drawing.Point(0, 501);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(630, 22);
            this.statusStripMain.TabIndex = 5;
            // 
            // toolStripUserName
            // 
            this.toolStripUserName.Name = "toolStripUserName";
            this.toolStripUserName.Size = new System.Drawing.Size(95, 17);
            this.toolStripUserName.Text = "ABC Address Book";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 523);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.toolMain);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.Text = "ABC AddressBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.toolMain.ResumeLayout(false);
            this.toolMain.PerformLayout();
            this.IconMenu.ResumeLayout(false);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databasePropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messagingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolMain;
        private System.Windows.Forms.ToolStripButton ContactsButton;
        private System.Windows.Forms.ToolStripButton InOutButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripUserName;
        private System.Windows.Forms.ToolStripMenuItem EditCategoriesMenuItem;
        private System.Windows.Forms.ContextMenuStrip IconMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMessageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem messageHistoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem whosOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printAddressBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MinimiseStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartupStripMenuItem;


    }
}

