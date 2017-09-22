using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Diagnostics;
using Microsoft.Reporting.WinForms;

namespace ABCAddressBook
{
    public partial class ContactViewForm : Form
    {
        private const int EDIT_MODE = 0;
        private const int NEW_MODE = 1;
        private int _contactID;
        private int _mode = EDIT_MODE;
        private ContactsForm _host;        

        public ContactViewForm()
        {
            InitializeComponent();
        }

        public void ViewContact(int contactID, ContactsForm host)
        {
            _host = host;
            CloseButton.Text = "&Close";
            FillCategoryCombo();
            GetContactInformation(contactID);
            LockFields(true);
            UpdateButton.Visible = false;
            SaveNewButton.Visible = false;            
            AsAboveButton.Visible = false;
            RecordInformationBox.Visible = true;
            this.MdiParent = host.MdiParent;
            this.WindowState = FormWindowState.Maximized;
            this.Show();                        
        }

        public void EditContact(int contactID, ContactsForm host)
        {
            _host = host;
            _mode = EDIT_MODE;
            CloseButton.Text = "&Cancel";
            FillCategoryCombo();
            GetContactInformation(contactID);
            LockFields(false);
            UpdateButton.Visible = true;
            SaveNewButton.Visible = false;
            AsAboveButton.Visible = true;
            RecordInformationBox.Visible = true;
            PrintButton.Visible = false;
            this.MdiParent = host.MdiParent;
            this.WindowState = FormWindowState.Maximized;
            this.Show();  
        }

        public void NewContact(ContactsForm host)
        {
            _host = host;
            _mode = NEW_MODE;
            CloseButton.Text = "&Cancel";
            FillCategoryCombo();            
            LockFields(false);
            UpdateButton.Visible = true;
            SaveNewButton.Visible = true;
            AsAboveButton.Visible = true;
            RecordInformationBox.Visible = false;
            PrintButton.Visible = false;
            this.MdiParent = host.MdiParent;
            this.WindowState = FormWindowState.Maximized;
            this.Show();  
        }

        private void GetContactInformation(int contactID)
        {
            _contactID = contactID;
            int bufferSize = 10;
            char[] textBuffer = new char[bufferSize];
            long startIndex = 0;
            string richText = "";
            bool rtf = false;

            FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
            fbcmd.CommandText = "SELECT CONTACT_ID, NAME, TELEPHONE, FACSIMILE, MOBILE, ADDRESS, SUBURB, STATE, POST_CODE, WEBSITE, EMAIL, POSTAL_ADDRESS, POSTAL_SUBURB, POSTAL_STATE, POSTAL_POST_CODE, ENTRY_DATE, NOTES, (SELECT CATEGORY FROM CATEGORIES WHERE CATEGORIES.CATEGORY_ID = CONTACTS.CATEGORY) AS CATEGORY FROM CONTACTS WHERE CONTACT_ID = " + contactID + ";";
            FbDataReader reader = fbcmd.ExecuteReader();            
   
            if (reader.HasRows)
            {
                reader.Read(); 
                NameText.Text = reader.GetString(reader.GetOrdinal("NAME"));
                TelephoneText.Text = reader.GetString(reader.GetOrdinal("TELEPHONE"));
                FacsimileText.Text = reader.GetString(reader.GetOrdinal("FACSIMILE"));
                MobileText.Text = reader.GetString(reader.GetOrdinal("MOBILE"));
                EmailText.Text = reader.GetString(reader.GetOrdinal("EMAIL"));
                WebsiteText.Text = reader.GetString(reader.GetOrdinal("WEBSITE"));                
                CategoryCombo.Text = reader.GetString(reader.GetOrdinal("CATEGORY"));

                LocationStreetText.Text = reader.GetString(reader.GetOrdinal("ADDRESS"));
                LocationSuburbText.Text = reader.GetString(reader.GetOrdinal("SUBURB"));
                LocationStateCombo.Text = reader.GetString(reader.GetOrdinal("STATE"));
                LocationPostCodeText.Text = reader.GetString(reader.GetOrdinal("POST_CODE"));

                PostalStreetText.Text = reader.GetString(reader.GetOrdinal("POSTAL_ADDRESS"));
                PostalSuburbText.Text = reader.GetString(reader.GetOrdinal("POSTAL_SUBURB"));
                PostalStateCombo.Text = reader.GetString(reader.GetOrdinal("POSTAL_STATE"));
                PostalPostCodeText.Text = reader.GetString(reader.GetOrdinal("POSTAL_POST_CODE"));

                EntryDateLabel.Text = reader.GetDateTime(reader.GetOrdinal("ENTRY_DATE")).ToShortDateString();
                

                try
                {
                    long retval = reader.GetChars(reader.GetOrdinal("NOTES"), 0, textBuffer, 0, bufferSize);

                    if (new string(textBuffer, 2, 3).Equals("rtf")) { rtf = true; }
                    while (retval == bufferSize)
                    {
                        richText += new string(textBuffer);

                        // Reposition the start index to the end of the last buffer and fill the buffer.
                        startIndex += bufferSize;
                        retval = reader.GetChars(reader.GetOrdinal("NOTES"), startIndex, textBuffer, 0, bufferSize);
                    }
                    richText += new string(textBuffer, 0, (int)retval);
                    if (rtf) { NotesRichText.Rtf = richText; }
                    else { NotesRichText.Text = richText; }
                }
                catch {} // Blob is null.
            }            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _host.SwitchTo();            
        }

        private void FillCategoryCombo()
        {
            FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
            fbcmd.CommandText = "SELECT CATEGORY_ID, CATEGORY FROM CATEGORIES ORDER BY CATEGORY ASC;";
            DataTable CategoriesTable = new DataTable();
            FbDataAdapter adapter = new FbDataAdapter(fbcmd);
            adapter.Fill(CategoriesTable);
            DataRow dr = CategoriesTable.NewRow();
            dr[0] = 0;
            dr[1] = "[Please Select]";
            CategoriesTable.Rows.InsertAt(dr, 0);
            
            CategoryCombo.DisplayMember = "CATEGORY";
            CategoryCombo.ValueMember = "CATEGORY_ID";
            CategoryCombo.DataSource = CategoriesTable;    
            CategoryCombo.SelectedValue = 0;
        }
        
        private void LockFields(bool enable)
        {
            NameText.ReadOnly = enable;            
            TelephoneText.ReadOnly = enable;
            FacsimileText.ReadOnly = enable;
            MobileText.ReadOnly = enable;
            EmailText.ReadOnly = enable;
            WebsiteText.ReadOnly = enable;

            LocationStreetText.ReadOnly = enable;
            LocationSuburbText.ReadOnly = enable;            
            LocationPostCodeText.ReadOnly = enable;

            PostalStreetText.ReadOnly = enable;
            PostalSuburbText.ReadOnly = enable;            
            PostalPostCodeText.ReadOnly = enable;

            NotesRichText.ReadOnly = enable;
            
            RTFToolStrip.Enabled = !enable;
        }

        private bool ValidateForm()
        {
            bool valid = false;
            if (NameText.Text.Length < 1) 
            { 
                MessageBox.Show("Please enter a name");
                valid = false; 
            } 
            else { valid = true; }
            
            if ((int)CategoryCombo.SelectedValue == 0) 
            { 
                MessageBox.Show("Please select a category"); 
                valid = false;
            } 
            else { valid = true; }
            
            return valid;
        }

        private bool SaveData()
        {
            //Validation            
            if (!ValidateForm()) { return false; }
            FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
            fbcmd.CommandType = CommandType.Text;

            switch (_mode)
            {
                case NEW_MODE:
                    fbcmd.CommandText = "INSERT INTO CONTACTS (NAME, TELEPHONE, FACSIMILE, MOBILE, ADDRESS, SUBURB, STATE, POST_CODE, WEBSITE, EMAIL, POSTAL_ADDRESS, POSTAL_SUBURB, POSTAL_STATE, POSTAL_POST_CODE, CATEGORY, NOTES) VALUES ('@NAME', '@TELEPHONE', '@FACSIMILE', '@MOBILE', '@ADDRESS', '@SUBURB', '@STATE', '@POST_CODE', '@WEBSITE', '@EMAIL', '@POSTAL_ADDRESS', '@POSTAL_SUBURB', '@POSTAL_STATE', '@POSTAL_POST_CODE', @CATEGORY, '@NOTES')";

                    fbcmd.CommandText = fbcmd.CommandText.Replace("@NAME", ABCUtilities.EscapeString(NameText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("@TELEPHONE", ABCUtilities.EscapeString(TelephoneText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("@FACSIMILE", ABCUtilities.EscapeString(FacsimileText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("@MOBILE", ABCUtilities.EscapeString(MobileText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("@WEBSITE", ABCUtilities.EscapeString(WebsiteText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("@EMAIL", ABCUtilities.EscapeString(EmailText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("@ADDRESS", ABCUtilities.EscapeString(LocationStreetText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("@SUBURB", ABCUtilities.EscapeString(LocationSuburbText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("@STATE", ABCUtilities.EscapeString(LocationStateCombo.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("@POST_CODE", ABCUtilities.EscapeString(LocationPostCodeText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("@POSTAL_ADDRESS", ABCUtilities.EscapeString(PostalStreetText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("@POSTAL_SUBURB", ABCUtilities.EscapeString(PostalSuburbText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("@POSTAL_STATE", ABCUtilities.EscapeString(PostalStateCombo.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("@POSTAL_POST_CODE", ABCUtilities.EscapeString(PostalPostCodeText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("@CATEGORY", CategoryCombo.SelectedValue.ToString());
                    fbcmd.CommandText = fbcmd.CommandText.Replace("@NOTES", NotesRichText.Rtf);
                    
                    fbcmd.ExecuteNonQuery();

                    break;

                case EDIT_MODE:                    
                    
                    fbcmd.CommandText = "UPDATE CONTACTS SET NAME = '%NAME', TELEPHONE = '%TELEPHONE', FACSIMILE = '%FACSIMILE', MOBILE = '%MOBILE', ADDRESS = '%ADDRESS', SUBURB = '%SUBURB', STATE = '%STATE', POST_CODE = '%POST_CODE', NOTES = '%NOTES', POSTAL_ADDRESS = '%POSTAL_ADDRESS', POSTAL_SUBURB = '%POSTAL_SUBURB', POSTAL_STATE = '%POSTAL_STATE', POSTAL_POST_CODE = '%POSTAL_POST_CODE', CATEGORY = '%CATEGORY', WEBSITE = '%WEBSITE', EMAIL = '%EMAIL' WHERE CONTACT_ID = " + _contactID;
                    
                    fbcmd.CommandText = fbcmd.CommandText.Replace("%NAME", ABCUtilities.EscapeString(NameText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("%TELEPHONE", ABCUtilities.EscapeString(TelephoneText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("%FACSIMILE", ABCUtilities.EscapeString(FacsimileText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("%MOBILE", ABCUtilities.EscapeString(MobileText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("%WEBSITE", ABCUtilities.EscapeString(WebsiteText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("%EMAIL", ABCUtilities.EscapeString(EmailText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("%ADDRESS", ABCUtilities.EscapeString(LocationStreetText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("%SUBURB", ABCUtilities.EscapeString(LocationSuburbText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("%STATE", ABCUtilities.EscapeString(LocationStateCombo.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("%POST_CODE", ABCUtilities.EscapeString(LocationPostCodeText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("%POSTAL_ADDRESS", ABCUtilities.EscapeString(PostalStreetText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("%POSTAL_SUBURB", ABCUtilities.EscapeString(PostalSuburbText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("%POSTAL_STATE", ABCUtilities.EscapeString(PostalStateCombo.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("%POSTAL_POST_CODE", ABCUtilities.EscapeString(PostalPostCodeText.Text));
                    fbcmd.CommandText = fbcmd.CommandText.Replace("%CATEGORY", CategoryCombo.SelectedValue.ToString());
                    fbcmd.CommandText = fbcmd.CommandText.Replace("%NOTES", ABCUtilities.EscapeString(NotesRichText.Rtf)); 
                    fbcmd.ExecuteNonQuery();
                    break;

                default: break;
            }

            return true;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                this.Close();
                _host.SwitchTo();
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = false;
            colorDialog.SolidColorOnly = true;
            colorDialog.Color = NotesRichText.SelectionColor;
            DialogResult result = colorDialog.ShowDialog();
            NotesRichText.SelectionColor = colorDialog.Color;
        }

        private void FontButton_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = false;
            fontDialog.AllowScriptChange = false;
            fontDialog.FontMustExist = true;
            fontDialog.Font = NotesRichText.SelectionFont;
            DialogResult result = fontDialog.ShowDialog();
            NotesRichText.SelectionFont = fontDialog.Font;
        }

        private void LeftAlignButton_Click(object sender, EventArgs e)
        {
            NotesRichText.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void CenterAlignButton_Click(object sender, EventArgs e)
        {
            NotesRichText.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void RightAlignButton_Click(object sender, EventArgs e)
        {
            NotesRichText.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void JustifyAlignButton_Click(object sender, EventArgs e)
        {            
        }

        private void BoldButton_Click(object sender, EventArgs e)
        {
            NotesRichText.SelectionFont = new Font(NotesRichText.SelectionFont, NotesRichText.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void ItalicButton_Click(object sender, EventArgs e)
        {
            NotesRichText.SelectionFont = new Font(NotesRichText.SelectionFont, NotesRichText.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void UnderlineButton_Click(object sender, EventArgs e)
        {
            NotesRichText.SelectionFont = new Font(NotesRichText.SelectionFont, NotesRichText.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void StrikeButton_Click(object sender, EventArgs e)
        {
            NotesRichText.SelectionFont = new Font(NotesRichText.SelectionFont, NotesRichText.SelectionFont.Style ^ FontStyle.Strikeout);
        }

        private void ResetFields()
        {
            NameText.Text = "";
            TelephoneText.Text = "";
            FacsimileText.Text = "";
            MobileText.Text = "";
            EmailText.Text = "";
            WebsiteText.Text = "";
            
            CategoryCombo.SelectedValue = 0;

            LocationStreetText.Text = "";
            LocationSuburbText.Text = "";
            LocationStateCombo.Text = "";
            LocationPostCodeText.Text = "";

            PostalStreetText.Text = "";
            PostalSuburbText.Text = "";
            PostalStateCombo.Text = "";
            PostalPostCodeText.Text = "";

            NotesRichText.Rtf = "";
        }

        private void AsAboveButton_Click(object sender, EventArgs e)
        {
            PostalStreetText.Text = LocationStreetText.Text;
            PostalSuburbText.Text = LocationSuburbText.Text;
            PostalStateCombo.Text = LocationStateCombo.Text;
            PostalPostCodeText.Text = LocationPostCodeText.Text; 
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
            fbcmd.CommandText = "SELECT NAME, TELEPHONE, FACSIMILE, MOBILE, ADDRESS, SUBURB, STATE, POST_CODE, WEBSITE, EMAIL, POSTAL_ADDRESS, POSTAL_SUBURB, POSTAL_STATE, POSTAL_POST_CODE, ENTRY_DATE, NOTES, (SELECT CATEGORY FROM CATEGORIES WHERE CATEGORIES.CATEGORY_ID = CONTACTS.CATEGORY) AS CATEGORY FROM CONTACTS WHERE CONTACT_ID = " + this._contactID + ";";
            FbDataReader reader = fbcmd.ExecuteReader();
            DataSet rDataSet = new DataSet();
            DataTable rTable = new DataTable();            
            rTable.Load(reader);            
            rTable.Rows[0]["NOTES"] = NotesRichText.Text;
            rTable.TableName = "Contact";
            rDataSet.Tables.Add(rTable);            
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "ReportData_Contact";
            rds.Value = rDataSet.Tables[0];
            ReportViewForm.ViewReport(rds, "ABCAddressBook.ContactDetailsReport.rdlc");
        }

        private void SaveNewButton_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                SavedLabel.Text = NameText.Text;
                SavedLabel.Visible = true;
                ResetFields();
            }
        }
    }
}