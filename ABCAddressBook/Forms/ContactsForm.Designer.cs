namespace ABCAddressBook
{
    partial class ContactsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsForm));
            this.ContactList = new System.Windows.Forms.ListView();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnTelephone = new System.Windows.Forms.ColumnHeader();
            this.columnFacsimile = new System.Windows.Forms.ColumnHeader();
            this.columnMobile = new System.Windows.Forms.ColumnHeader();
            this.columnCategory = new System.Windows.Forms.ColumnHeader();
            this.ContactsToolStrip = new System.Windows.Forms.ToolStrip();
            this.SearchTextLabel = new System.Windows.Forms.ToolStripLabel();
            this.SearchText = new System.Windows.Forms.ToolStripTextBox();
            this.SearchCategoryLabel = new System.Windows.Forms.ToolStripLabel();
            this.CategoryCombo = new System.Windows.Forms.ToolStripComboBox();
            this.ViewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PhoneLabel = new System.Windows.Forms.ToolStripLabel();
            this.ContactABCSelector = new ABCAddressBook.ABCSelector();
            this.ContactsToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactList
            // 
            this.ContactList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ContactList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContactList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnTelephone,
            this.columnFacsimile,
            this.columnMobile,
            this.columnCategory});
            this.ContactList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactList.FullRowSelect = true;
            this.ContactList.GridLines = true;
            this.ContactList.Location = new System.Drawing.Point(32, 48);
            this.ContactList.MultiSelect = false;
            this.ContactList.Name = "ContactList";
            this.ContactList.Size = new System.Drawing.Size(784, 376);
            this.ContactList.TabIndex = 1;
            this.ContactList.UseCompatibleStateImageBehavior = false;
            this.ContactList.View = System.Windows.Forms.View.Details;
            this.ContactList.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.ContactList_ColumnWidthChanged);
            this.ContactList.DoubleClick += new System.EventHandler(this.ViewButton_Click);
            this.ContactList.SelectedIndexChanged += new System.EventHandler(this.ContactList_SelectedIndexChanged);
            this.ContactList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ContactList_ColumnClick);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = global::ABCAddressBook.Properties.Settings.Default.ContactsColumnName;
            // 
            // columnTelephone
            // 
            this.columnTelephone.Text = "Telephone";
            this.columnTelephone.Width = global::ABCAddressBook.Properties.Settings.Default.ContactsColumnTelephone;
            // 
            // columnFacsimile
            // 
            this.columnFacsimile.Text = "Facsimile";
            this.columnFacsimile.Width = global::ABCAddressBook.Properties.Settings.Default.ContactsColumnFacsimile;
            // 
            // columnMobile
            // 
            this.columnMobile.Text = "Mobile";
            this.columnMobile.Width = global::ABCAddressBook.Properties.Settings.Default.ContactsColumnMobile;
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Category";
            this.columnCategory.Width = global::ABCAddressBook.Properties.Settings.Default.ContactsColumnCategory;
            // 
            // ContactsToolStrip
            // 
            this.ContactsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchTextLabel,
            this.SearchText,
            this.SearchCategoryLabel,
            this.CategoryCombo,
            this.ViewButton,
            this.EditButton,
            this.NewButton,
            this.DeleteButton,
            this.toolStripSeparator1,
            this.PhoneLabel});
            this.ContactsToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ContactsToolStrip.Name = "ContactsToolStrip";
            this.ContactsToolStrip.Size = new System.Drawing.Size(817, 44);
            this.ContactsToolStrip.TabIndex = 6;
            this.ContactsToolStrip.Text = "toolStrip1";
            // 
            // SearchTextLabel
            // 
            this.SearchTextLabel.Name = "SearchTextLabel";
            this.SearchTextLabel.Size = new System.Drawing.Size(69, 41);
            this.SearchTextLabel.Text = "Search Text:";
            // 
            // SearchText
            // 
            this.SearchText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(150, 44);
            this.SearchText.Text = "A";
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // SearchCategoryLabel
            // 
            this.SearchCategoryLabel.Name = "SearchCategoryLabel";
            this.SearchCategoryLabel.Size = new System.Drawing.Size(56, 41);
            this.SearchCategoryLabel.Text = "Category:";
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(121, 44);
            this.CategoryCombo.SelectedIndexChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // ViewButton
            // 
            this.ViewButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewButton.Image")));
            this.ViewButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(33, 41);
            this.ViewButton.Text = "View";
            this.ViewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(29, 41);
            this.EditButton.Text = "Edit";
            this.EditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(32, 41);
            this.NewButton.Text = "New";
            this.NewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.ForeColor = System.Drawing.Color.Navy;
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(62, 41);
            this.PhoneLabel.Text = "     ";
            // 
            // ContactABCSelector
            // 
            this.ContactABCSelector.Location = new System.Drawing.Point(0, 48);
            this.ContactABCSelector.Name = "ContactABCSelector";
            this.ContactABCSelector.Size = new System.Drawing.Size(32, 525);
            this.ContactABCSelector.TabIndex = 0;
            this.ContactABCSelector.SelectorClickHandler += new ABCAddressBook.ABCSelector.ABCSelectorClick(this.ContactABCSelector_SelectorClickHandler);
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 605);
            this.ControlBox = false;
            this.Controls.Add(this.ContactsToolStrip);
            this.Controls.Add(this.ContactList);
            this.Controls.Add(this.ContactABCSelector);
            this.Name = "ContactsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.ContactsForm_Load);
            this.ContactsToolStrip.ResumeLayout(false);
            this.ContactsToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ABCSelector ContactABCSelector;
        private System.Windows.Forms.ListView ContactList;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnTelephone;
        private System.Windows.Forms.ColumnHeader columnFacsimile;
        private System.Windows.Forms.ColumnHeader columnMobile;
        private System.Windows.Forms.ColumnHeader columnCategory;
        private System.Windows.Forms.ToolStrip ContactsToolStrip;
        private System.Windows.Forms.ToolStripButton ViewButton;
        private System.Windows.Forms.ToolStripTextBox SearchText;
        private System.Windows.Forms.ToolStripComboBox CategoryCombo;
        private System.Windows.Forms.ToolStripLabel SearchTextLabel;
        private System.Windows.Forms.ToolStripLabel SearchCategoryLabel;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel PhoneLabel;






    }
}