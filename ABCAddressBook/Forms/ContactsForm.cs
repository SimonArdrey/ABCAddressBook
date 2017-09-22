using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Diagnostics;

namespace ABCAddressBook
{
    public partial class ContactsForm : Form
    {
        private string _orderField = "NAME";
        private ContactViewForm _contactViewForm = new ContactViewForm();

        public ContactsForm()
        {
            InitializeComponent();
        }

        private void ContactsForm_Load(object sender, EventArgs e)
        {
            ContactList.Width = this.ClientSize.Width - ContactList.Left;
            ContactList.Height = this.ClientSize.Height - ContactList.Top;
            ContactList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;

            ContactABCSelector.Height = this.ClientSize.Height - ContactABCSelector.Top;
            ContactABCSelector.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;

            FillCategoryCombo();
            ListContacts();          
        }

        private void FillCategoryCombo()
        {
            CategoryCombo.Items.Add("[Any]");

            FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
            fbcmd.CommandText = "SELECT CATEGORY FROM CATEGORIES ORDER BY CATEGORY ASC;";            
            FbDataReader reader = fbcmd.ExecuteReader();
            while (reader.Read())
            {
                CategoryCombo.Items.Add(reader.GetString(reader.GetOrdinal("CATEGORY")));
            }            
            CategoryCombo.SelectedIndex = 0;
        }

        private void ContactABCSelector_SelectorClickHandler(object sender, ABCSelectorEventArgs e)
        {
            SearchText.Text = e.SelectedLetter;
        }

        private void ListContacts()
        {
            ContactList.SuspendLayout();
            ArrayList itemsList = new ArrayList();            
            ListViewItem[] itemsArray;
            
            FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
            if (CategoryCombo.Text.Equals("[Any]"))
            {
                fbcmd.CommandText = "SELECT FIRST 100 CONTACT_ID, NAME, TELEPHONE, FACSIMILE, MOBILE, (SELECT CATEGORY FROM CATEGORIES WHERE CATEGORIES.CATEGORY_ID = CONTACTS.CATEGORY) AS CATEGORY FROM CONTACTS WHERE NAME LIKE '" + SearchText.Text + "%' ORDER BY " + _orderField + " ASC;";
            }
            else
            { fbcmd.CommandText = "SELECT FIRST 100 CONTACT_ID, NAME, TELEPHONE, FACSIMILE, MOBILE, (SELECT CATEGORY FROM CATEGORIES WHERE CATEGORIES.CATEGORY_ID = CONTACTS.CATEGORY) AS CATEGORY FROM CONTACTS WHERE NAME LIKE '" + SearchText.Text + "%' AND CATEGORY IN (SELECT CATEGORY_ID FROM CATEGORIES WHERE CATEGORY LIKE '" + CategoryCombo.Text + "%') ORDER BY " + _orderField + " ASC;"; }            
            FbDataReader reader = fbcmd.ExecuteReader();            
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(new string[] { reader.GetString(reader.GetOrdinal("NAME")), reader.GetString(reader.GetOrdinal("TELEPHONE")), reader.GetString(reader.GetOrdinal("FACSIMILE")), reader.GetString(reader.GetOrdinal("MOBILE")), reader.GetString(reader.GetOrdinal("CATEGORY"))});
                item.Tag = reader.GetInt32(reader.GetOrdinal("CONTACT_ID"));
                item.UseItemStyleForSubItems = false;
                item.SubItems[0].ForeColor = Color.DarkBlue;
                item.SubItems[1].ForeColor = Color.DarkGreen;
                item.SubItems[2].ForeColor = Color.DarkBlue;
                item.SubItems[3].ForeColor = Color.DarkGreen;
                item.SubItems[4].ForeColor = Color.DarkBlue;
                itemsList.Add(item);                
            }            

            itemsArray = (ListViewItem[])itemsList.ToArray(typeof(ListViewItem));
            ContactList.Items.Clear();
            ContactList.Items.AddRange(itemsArray);
            ContactList.ResumeLayout();
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        { ListContacts(); }

        private void SearchText_KeyPress(object sender, KeyPressEventArgs e)
        {
            String c = Convert.ToString(e.KeyChar).ToUpper();
            e.KeyChar = Convert.ToChar(c);
        }

        private void ContactList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 0: _orderField = "NAME"; break;
                case 4: _orderField = "CATEGORY"; break;                
            }
            ListContacts();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {            
            _contactViewForm = new ContactViewForm();
            _contactViewForm.WindowState = FormWindowState.Maximized;
            if (ContactList.SelectedItems.Count == 1)
            {
                this.Hide();
                _contactViewForm.ViewContact((int)ContactList.SelectedItems[0].Tag, this);
            }
            else { MessageBox.Show("Please select a contact."); }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {            
            _contactViewForm = new ContactViewForm();
            _contactViewForm.FormClosed += new FormClosedEventHandler(ContactClosed);
            _contactViewForm.WindowState = FormWindowState.Maximized;
            if (ContactList.SelectedItems.Count == 1)
            {
                this.Hide();
                _contactViewForm.EditContact((int)ContactList.SelectedItems[0].Tag, this);
            }
            else { MessageBox.Show("Please select a contact."); }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            _contactViewForm = new ContactViewForm();
            _contactViewForm.FormClosed += new FormClosedEventHandler(ContactClosed);
            _contactViewForm.WindowState = FormWindowState.Maximized;
            _contactViewForm.NewContact(this);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ContactList.SelectedItems.Count == 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + ContactList.SelectedItems[0].Text + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
                    fbcmd.CommandText = "DELETE FROM CONTACTS WHERE CONTACT_ID = @CONTACT_ID";
                    fbcmd.Parameters.Add("@CONTACT_ID", ContactList.SelectedItems[0].Tag);
                    ListContacts();

                    try { fbcmd.ExecuteNonQuery(); }
                    catch (FbException ex)
                    {
                        if (ex.ErrorCode == -2147467259)
                        {
                            MessageBox.Show("You do not have permission to delete contacts.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                    
                }
            }
            else { MessageBox.Show("Please select a contact."); }
        }

        public void SwitchTo()
        {
            if (_contactViewForm.Visible) { _contactViewForm.Show(); }
            else 
            {
                this.WindowState = FormWindowState.Maximized; 
                this.Show();                
            }
        }

        private void ContactClosed(object sender, FormClosedEventArgs e)
        {
            ListContacts();
        }

        private void ContactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactList.SelectedItems.Count > 0)
            {
                PhoneLabel.Text = ContactList.SelectedItems[0].SubItems[1].Text + " - " + ContactList.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void ContactList_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            //MessageBox.Show(Properties.Settings.Default.ContactsColumnName.ToString());
        }
    }
}