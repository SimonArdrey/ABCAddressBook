namespace ABCAddressBook
{
    partial class ContactViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactViewForm));
            this.ContactTabControl = new System.Windows.Forms.TabControl();
            this.GeneralTab = new System.Windows.Forms.TabPage();
            this.SavedLabel = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.SaveNewButton = new System.Windows.Forms.Button();
            this.RTFToolStrip = new System.Windows.Forms.ToolStrip();
            this.FontButton = new System.Windows.Forms.ToolStripButton();
            this.ColorButton = new System.Windows.Forms.ToolStripButton();
            this.RTFSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.BoldButton = new System.Windows.Forms.ToolStripButton();
            this.ItalicButton = new System.Windows.Forms.ToolStripButton();
            this.UnderlineButton = new System.Windows.Forms.ToolStripButton();
            this.StrikeButton = new System.Windows.Forms.ToolStripButton();
            this.RTFSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.LeftAlignButton = new System.Windows.Forms.ToolStripButton();
            this.CenterAlignButton = new System.Windows.Forms.ToolStripButton();
            this.RightAlignButton = new System.Windows.Forms.ToolStripButton();
            this.RecordInformationBox = new System.Windows.Forms.GroupBox();
            this.EntryDateLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.NotesRichText = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AsAboveButton = new System.Windows.Forms.Button();
            this.PostalPostCodeText = new System.Windows.Forms.TextBox();
            this.PostalStateCombo = new System.Windows.Forms.ComboBox();
            this.PostalSuburbText = new System.Windows.Forms.TextBox();
            this.PostalStreetText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LocationPostCodeText = new System.Windows.Forms.TextBox();
            this.LocationStateCombo = new System.Windows.Forms.ComboBox();
            this.LocationSuburbText = new System.Windows.Forms.TextBox();
            this.LocationStreetText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.WebsiteText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.MobileText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FacsimileText = new System.Windows.Forms.TextBox();
            this.TelephoneText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ContactTabControl.SuspendLayout();
            this.GeneralTab.SuspendLayout();
            this.RTFToolStrip.SuspendLayout();
            this.RecordInformationBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactTabControl
            // 
            this.ContactTabControl.Controls.Add(this.GeneralTab);
            this.ContactTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContactTabControl.Location = new System.Drawing.Point(0, 0);
            this.ContactTabControl.Name = "ContactTabControl";
            this.ContactTabControl.SelectedIndex = 0;
            this.ContactTabControl.Size = new System.Drawing.Size(850, 592);
            this.ContactTabControl.TabIndex = 0;
            // 
            // GeneralTab
            // 
            this.GeneralTab.Controls.Add(this.SavedLabel);
            this.GeneralTab.Controls.Add(this.PrintButton);
            this.GeneralTab.Controls.Add(this.SaveNewButton);
            this.GeneralTab.Controls.Add(this.RTFToolStrip);
            this.GeneralTab.Controls.Add(this.RecordInformationBox);
            this.GeneralTab.Controls.Add(this.CloseButton);
            this.GeneralTab.Controls.Add(this.UpdateButton);
            this.GeneralTab.Controls.Add(this.NotesRichText);
            this.GeneralTab.Controls.Add(this.groupBox2);
            this.GeneralTab.Controls.Add(this.groupBox1);
            this.GeneralTab.Controls.Add(this.WebsiteText);
            this.GeneralTab.Controls.Add(this.EmailText);
            this.GeneralTab.Controls.Add(this.MobileText);
            this.GeneralTab.Controls.Add(this.label7);
            this.GeneralTab.Controls.Add(this.label6);
            this.GeneralTab.Controls.Add(this.label5);
            this.GeneralTab.Controls.Add(this.FacsimileText);
            this.GeneralTab.Controls.Add(this.TelephoneText);
            this.GeneralTab.Controls.Add(this.label4);
            this.GeneralTab.Controls.Add(this.label3);
            this.GeneralTab.Controls.Add(this.CategoryCombo);
            this.GeneralTab.Controls.Add(this.label2);
            this.GeneralTab.Controls.Add(this.NameText);
            this.GeneralTab.Controls.Add(this.label1);
            this.GeneralTab.Location = new System.Drawing.Point(4, 22);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralTab.Size = new System.Drawing.Size(842, 566);
            this.GeneralTab.TabIndex = 0;
            this.GeneralTab.Text = "General Information";
            this.GeneralTab.UseVisualStyleBackColor = true;            
            // 
            // SavedLabel
            // 
            this.SavedLabel.AutoSize = true;
            this.SavedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavedLabel.ForeColor = System.Drawing.Color.Red;
            this.SavedLabel.Location = new System.Drawing.Point(416, 520);
            this.SavedLabel.Name = "SavedLabel";
            this.SavedLabel.Size = new System.Drawing.Size(208, 13);
            this.SavedLabel.TabIndex = 23;
            this.SavedLabel.Text = "SAVED: Name###############";
            this.SavedLabel.Visible = false;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(416, 488);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(112, 24);
            this.PrintButton.TabIndex = 22;
            this.PrintButton.Text = "Print Contact";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // SaveNewButton
            // 
            this.SaveNewButton.Location = new System.Drawing.Point(656, 456);
            this.SaveNewButton.Name = "SaveNewButton";
            this.SaveNewButton.Size = new System.Drawing.Size(112, 24);
            this.SaveNewButton.TabIndex = 21;
            this.SaveNewButton.Text = "Save and New";
            this.SaveNewButton.UseVisualStyleBackColor = true;
            this.SaveNewButton.Visible = false;
            this.SaveNewButton.Click += new System.EventHandler(this.SaveNewButton_Click);
            // 
            // RTFToolStrip
            // 
            this.RTFToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.RTFToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontButton,
            this.ColorButton,
            this.RTFSep2,
            this.BoldButton,
            this.ItalicButton,
            this.UnderlineButton,
            this.StrikeButton,
            this.RTFSep1,
            this.LeftAlignButton,
            this.CenterAlignButton,
            this.RightAlignButton});
            this.RTFToolStrip.Location = new System.Drawing.Point(416, 8);
            this.RTFToolStrip.Name = "RTFToolStrip";
            this.RTFToolStrip.Size = new System.Drawing.Size(258, 25);
            this.RTFToolStrip.TabIndex = 20;
            // 
            // FontButton
            // 
            this.FontButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FontButton.Image = ((System.Drawing.Image)(resources.GetObject("FontButton.Image")));
            this.FontButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(33, 22);
            this.FontButton.Text = "Font";
            this.FontButton.ToolTipText = "Font";
            this.FontButton.Click += new System.EventHandler(this.FontButton_Click);
            // 
            // ColorButton
            // 
            this.ColorButton.BackColor = System.Drawing.SystemColors.Control;
            this.ColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(42, 22);
            this.ColorButton.Text = "Colour";
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // RTFSep2
            // 
            this.RTFSep2.Name = "RTFSep2";
            this.RTFSep2.Size = new System.Drawing.Size(6, 25);
            // 
            // BoldButton
            // 
            this.BoldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldButton.Image = ((System.Drawing.Image)(resources.GetObject("BoldButton.Image")));
            this.BoldButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.BoldButton.Name = "BoldButton";
            this.BoldButton.Size = new System.Drawing.Size(23, 22);
            this.BoldButton.Text = "Bold";
            this.BoldButton.Click += new System.EventHandler(this.BoldButton_Click);
            // 
            // ItalicButton
            // 
            this.ItalicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalicButton.Image = ((System.Drawing.Image)(resources.GetObject("ItalicButton.Image")));
            this.ItalicButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.ItalicButton.Name = "ItalicButton";
            this.ItalicButton.Size = new System.Drawing.Size(23, 22);
            this.ItalicButton.Text = "Italic";
            this.ItalicButton.Click += new System.EventHandler(this.ItalicButton_Click);
            // 
            // UnderlineButton
            // 
            this.UnderlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnderlineButton.Image = ((System.Drawing.Image)(resources.GetObject("UnderlineButton.Image")));
            this.UnderlineButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.UnderlineButton.Name = "UnderlineButton";
            this.UnderlineButton.Size = new System.Drawing.Size(23, 22);
            this.UnderlineButton.Text = "Underline";
            this.UnderlineButton.Click += new System.EventHandler(this.UnderlineButton_Click);
            // 
            // StrikeButton
            // 
            this.StrikeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StrikeButton.Image = ((System.Drawing.Image)(resources.GetObject("StrikeButton.Image")));
            this.StrikeButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.StrikeButton.Name = "StrikeButton";
            this.StrikeButton.Size = new System.Drawing.Size(23, 22);
            this.StrikeButton.Text = "Strike Through";
            this.StrikeButton.Click += new System.EventHandler(this.StrikeButton_Click);
            // 
            // RTFSep1
            // 
            this.RTFSep1.Name = "RTFSep1";
            this.RTFSep1.Size = new System.Drawing.Size(6, 25);
            // 
            // LeftAlignButton
            // 
            this.LeftAlignButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LeftAlignButton.Image = ((System.Drawing.Image)(resources.GetObject("LeftAlignButton.Image")));
            this.LeftAlignButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.LeftAlignButton.Name = "LeftAlignButton";
            this.LeftAlignButton.Size = new System.Drawing.Size(23, 22);
            this.LeftAlignButton.Text = "Align Left";
            this.LeftAlignButton.Click += new System.EventHandler(this.LeftAlignButton_Click);
            // 
            // CenterAlignButton
            // 
            this.CenterAlignButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CenterAlignButton.Image = ((System.Drawing.Image)(resources.GetObject("CenterAlignButton.Image")));
            this.CenterAlignButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.CenterAlignButton.Name = "CenterAlignButton";
            this.CenterAlignButton.Size = new System.Drawing.Size(23, 22);
            this.CenterAlignButton.Text = "Align Centre";
            this.CenterAlignButton.Click += new System.EventHandler(this.CenterAlignButton_Click);
            // 
            // RightAlignButton
            // 
            this.RightAlignButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RightAlignButton.Image = ((System.Drawing.Image)(resources.GetObject("RightAlignButton.Image")));
            this.RightAlignButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.RightAlignButton.Name = "RightAlignButton";
            this.RightAlignButton.Size = new System.Drawing.Size(23, 22);
            this.RightAlignButton.Text = "Align Right";
            this.RightAlignButton.Click += new System.EventHandler(this.RightAlignButton_Click);
            // 
            // RecordInformationBox
            // 
            this.RecordInformationBox.Controls.Add(this.EntryDateLabel);
            this.RecordInformationBox.Controls.Add(this.label16);
            this.RecordInformationBox.Location = new System.Drawing.Point(8, 456);
            this.RecordInformationBox.Name = "RecordInformationBox";
            this.RecordInformationBox.Size = new System.Drawing.Size(400, 64);
            this.RecordInformationBox.TabIndex = 19;
            this.RecordInformationBox.TabStop = false;
            this.RecordInformationBox.Text = "Record Information";
            // 
            // EntryDateLabel
            // 
            this.EntryDateLabel.AutoSize = true;
            this.EntryDateLabel.Location = new System.Drawing.Point(72, 16);
            this.EntryDateLabel.Name = "EntryDateLabel";
            this.EntryDateLabel.Size = new System.Drawing.Size(21, 13);
            this.EntryDateLabel.TabIndex = 1;
            this.EntryDateLabel.Text = "##";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Entry Date:";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(416, 456);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(112, 24);
            this.CloseButton.TabIndex = 18;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(536, 456);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(112, 24);
            this.UpdateButton.TabIndex = 17;
            this.UpdateButton.Text = "Save and Close";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Visible = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // NotesRichText
            // 
            this.NotesRichText.AcceptsTab = true;
            this.NotesRichText.EnableAutoDragDrop = true;
            this.NotesRichText.Location = new System.Drawing.Point(416, 32);
            this.NotesRichText.Name = "NotesRichText";
            this.NotesRichText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.NotesRichText.ShowSelectionMargin = true;
            this.NotesRichText.Size = new System.Drawing.Size(384, 416);
            this.NotesRichText.TabIndex = 16;
            this.NotesRichText.Text = "";
            this.NotesRichText.WordWrap = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AsAboveButton);
            this.groupBox2.Controls.Add(this.PostalPostCodeText);
            this.groupBox2.Controls.Add(this.PostalStateCombo);
            this.groupBox2.Controls.Add(this.PostalSuburbText);
            this.groupBox2.Controls.Add(this.PostalStreetText);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(8, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 128);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Postal / Correspondence Address";
            // 
            // AsAboveButton
            // 
            this.AsAboveButton.Location = new System.Drawing.Point(296, 96);
            this.AsAboveButton.Name = "AsAboveButton";
            this.AsAboveButton.Size = new System.Drawing.Size(96, 24);
            this.AsAboveButton.TabIndex = 8;
            this.AsAboveButton.Text = "As Above";
            this.AsAboveButton.UseVisualStyleBackColor = true;
            this.AsAboveButton.Click += new System.EventHandler(this.AsAboveButton_Click);
            // 
            // PostalPostCodeText
            // 
            this.PostalPostCodeText.Location = new System.Drawing.Point(144, 96);
            this.PostalPostCodeText.MaxLength = 5;
            this.PostalPostCodeText.Name = "PostalPostCodeText";
            this.PostalPostCodeText.Size = new System.Drawing.Size(104, 20);
            this.PostalPostCodeText.TabIndex = 7;
            // 
            // PostalStateCombo
            // 
            this.PostalStateCombo.FormattingEnabled = true;
            this.PostalStateCombo.Items.AddRange(new object[] {
            "QLD",
            "NSW",
            "VIC",
            "ACT",
            "TAS",
            "SA",
            "NT",
            "WA",
            "JBT"});
            this.PostalStateCombo.Location = new System.Drawing.Point(144, 72);
            this.PostalStateCombo.MaxLength = 20;
            this.PostalStateCombo.Name = "PostalStateCombo";
            this.PostalStateCombo.Size = new System.Drawing.Size(104, 21);
            this.PostalStateCombo.TabIndex = 6;
            // 
            // PostalSuburbText
            // 
            this.PostalSuburbText.Location = new System.Drawing.Point(144, 48);
            this.PostalSuburbText.MaxLength = 30;
            this.PostalSuburbText.Name = "PostalSuburbText";
            this.PostalSuburbText.Size = new System.Drawing.Size(152, 20);
            this.PostalSuburbText.TabIndex = 5;
            // 
            // PostalStreetText
            // 
            this.PostalStreetText.Location = new System.Drawing.Point(144, 24);
            this.PostalStreetText.MaxLength = 100;
            this.PostalStreetText.Name = "PostalStreetText";
            this.PostalStreetText.Size = new System.Drawing.Size(248, 20);
            this.PostalStreetText.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Post / ZIP Code:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "State / Province:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Suburb:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Street Address:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LocationPostCodeText);
            this.groupBox1.Controls.Add(this.LocationStateCombo);
            this.groupBox1.Controls.Add(this.LocationSuburbText);
            this.groupBox1.Controls.Add(this.LocationStreetText);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(8, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 128);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location Address";
            // 
            // LocationPostCodeText
            // 
            this.LocationPostCodeText.Location = new System.Drawing.Point(144, 96);
            this.LocationPostCodeText.MaxLength = 5;
            this.LocationPostCodeText.Name = "LocationPostCodeText";
            this.LocationPostCodeText.Size = new System.Drawing.Size(104, 20);
            this.LocationPostCodeText.TabIndex = 7;
            // 
            // LocationStateCombo
            // 
            this.LocationStateCombo.FormattingEnabled = true;
            this.LocationStateCombo.Items.AddRange(new object[] {
            "QLD",
            "NSW",
            "VIC",
            "ACT",
            "TAS",
            "SA",
            "NT",
            "WA",
            "JBT"});
            this.LocationStateCombo.Location = new System.Drawing.Point(144, 72);
            this.LocationStateCombo.MaxLength = 20;
            this.LocationStateCombo.Name = "LocationStateCombo";
            this.LocationStateCombo.Size = new System.Drawing.Size(104, 21);
            this.LocationStateCombo.TabIndex = 6;
            // 
            // LocationSuburbText
            // 
            this.LocationSuburbText.Location = new System.Drawing.Point(144, 48);
            this.LocationSuburbText.MaxLength = 30;
            this.LocationSuburbText.Name = "LocationSuburbText";
            this.LocationSuburbText.Size = new System.Drawing.Size(152, 20);
            this.LocationSuburbText.TabIndex = 5;
            // 
            // LocationStreetText
            // 
            this.LocationStreetText.Location = new System.Drawing.Point(144, 24);
            this.LocationStreetText.MaxLength = 100;
            this.LocationStreetText.Name = "LocationStreetText";
            this.LocationStreetText.Size = new System.Drawing.Size(248, 20);
            this.LocationStreetText.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Post / ZIP Code:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "State / Province:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Suburb:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Street Address:";
            // 
            // WebsiteText
            // 
            this.WebsiteText.Location = new System.Drawing.Point(152, 152);
            this.WebsiteText.MaxLength = 100;
            this.WebsiteText.Name = "WebsiteText";
            this.WebsiteText.Size = new System.Drawing.Size(248, 20);
            this.WebsiteText.TabIndex = 13;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(152, 128);
            this.EmailText.MaxLength = 100;
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(248, 20);
            this.EmailText.TabIndex = 12;
            // 
            // MobileText
            // 
            this.MobileText.Location = new System.Drawing.Point(152, 104);
            this.MobileText.MaxLength = 15;
            this.MobileText.Name = "MobileText";
            this.MobileText.Size = new System.Drawing.Size(128, 20);
            this.MobileText.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Website:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mobile:";
            // 
            // FacsimileText
            // 
            this.FacsimileText.Location = new System.Drawing.Point(152, 80);
            this.FacsimileText.MaxLength = 15;
            this.FacsimileText.Name = "FacsimileText";
            this.FacsimileText.Size = new System.Drawing.Size(128, 20);
            this.FacsimileText.TabIndex = 7;
            // 
            // TelephoneText
            // 
            this.TelephoneText.Location = new System.Drawing.Point(152, 56);
            this.TelephoneText.MaxLength = 15;
            this.TelephoneText.Name = "TelephoneText";
            this.TelephoneText.Size = new System.Drawing.Size(128, 20);
            this.TelephoneText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Facsimile:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telephone:";
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Location = new System.Drawing.Point(152, 32);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(184, 21);
            this.CategoryCombo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category:";
            // 
            // NameText
            // 
            this.NameText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NameText.Location = new System.Drawing.Point(152, 8);
            this.NameText.MaxLength = 100;
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(248, 20);
            this.NameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // ContactViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 610);
            this.ControlBox = false;
            this.Controls.Add(this.ContactTabControl);
            this.Name = "ContactViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contact";            
            this.ContactTabControl.ResumeLayout(false);
            this.GeneralTab.ResumeLayout(false);
            this.GeneralTab.PerformLayout();
            this.RTFToolStrip.ResumeLayout(false);
            this.RTFToolStrip.PerformLayout();
            this.RecordInformationBox.ResumeLayout(false);
            this.RecordInformationBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ContactTabControl;
        private System.Windows.Forms.TabPage GeneralTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.ComboBox CategoryCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FacsimileText;
        private System.Windows.Forms.TextBox TelephoneText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox WebsiteText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox MobileText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LocationStreetText;
        private System.Windows.Forms.ComboBox LocationStateCombo;
        private System.Windows.Forms.TextBox LocationSuburbText;
        private System.Windows.Forms.TextBox LocationPostCodeText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PostalPostCodeText;
        private System.Windows.Forms.ComboBox PostalStateCombo;
        private System.Windows.Forms.TextBox PostalSuburbText;
        private System.Windows.Forms.TextBox PostalStreetText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox NotesRichText;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.GroupBox RecordInformationBox;
        private System.Windows.Forms.Label EntryDateLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStrip RTFToolStrip;
        private System.Windows.Forms.ToolStripButton BoldButton;
        private System.Windows.Forms.ToolStripButton ItalicButton;
        private System.Windows.Forms.ToolStripButton UnderlineButton;
        private System.Windows.Forms.ToolStripButton LeftAlignButton;
        private System.Windows.Forms.ToolStripButton CenterAlignButton;
        private System.Windows.Forms.ToolStripButton RightAlignButton;
        private System.Windows.Forms.ToolStripButton StrikeButton;
        private System.Windows.Forms.ToolStripSeparator RTFSep2;
        private System.Windows.Forms.ToolStripSeparator RTFSep1;
        private System.Windows.Forms.ToolStripButton ColorButton;
        private System.Windows.Forms.ToolStripButton FontButton;
        private System.Windows.Forms.Button SaveNewButton;
        private System.Windows.Forms.Button AsAboveButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Label SavedLabel;
    }
}