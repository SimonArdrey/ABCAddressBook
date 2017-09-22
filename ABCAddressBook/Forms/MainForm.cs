using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Diagnostics;
using System.Configuration;
using System.Resources;
using Microsoft.Reporting.WinForms;
using System.Threading;
using Microsoft.Win32;

namespace ABCAddressBook
{
    public partial class MainForm : Form
    {
        private ContactsForm _contactsForm = new ContactsForm();
        private InOutBoardForm _inOutForm = new InOutBoardForm();
        public delegate void DisplayMessageDelegate(int messageID);
        public delegate void CommandsDelegate(string[] args);        
        public DisplayMessageDelegate DisplayMessage;
        public CommandsDelegate RemoteCommandsEvent;        

        private enum DisplayForm
        {
            Contacts = 1,
            InOutBoard = 2,
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MinimiseStripMenuItem.Checked = ABCUtilities.GetRegistryValueBool("HideOnStart");
            if (ABCUtilities.GetRegistryValueBool("HideOnStart"))
            { this.Hide(); }

            StartupStripMenuItem.Checked = this.IsAutoStart();

            _contactsForm.MdiParent = this;
            _contactsForm.WindowState = FormWindowState.Maximized;
            _contactsForm.Show();

            _inOutForm.MdiParent = this;
            _inOutForm.WindowState = FormWindowState.Maximized;            

            toolStripUserName.Text = "User: " + ABCUtilities.GetUserName();

            DisplayMessage = new DisplayMessageDelegate(DisplayReceivedMessage);
            RemoteCommandsEvent = new CommandsDelegate(RemoteCommands);

            if (ABCUtilities.SingleUserVersion)
            {
                databasePropertiesToolStripMenuItem.Visible = false;
            }

            if (!ABCUtilities.UsingServer)
            {
                messagingToolStripMenuItem.Visible = false;
                messageHistoryToolStripMenuItem1.Visible = false;
                sendMessageToolStripMenuItem1.Visible = false;
                whosOnlineToolStripMenuItem.Visible = false;
            }
            else
            {
                ABCUtilities.GetUnreadMessages();
                ABCUtilities.GetMessages();                
            }

            DisplayRegistered();
            
            //notifyIcon.ShowBalloonTip(1, "ABC Address Book", "Address Book up and running.", ToolTipIcon.Info);
        }

        private void DisplayRegistered()
        {
            if (ABCUtilities.Registered)
            {
                this.Text = "ABC Address Book   Registered to " + ABCUtilities.GetRegistrationName();
                RegisterToolStripMenuItem.Visible = false;
            }
            else { this.Text = "ABC Address Book   UNREGISTERED"; }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.TopLevel = true;
            this.Show();
        this.WindowState = FormWindowState.Maximized;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABCUtilities.Quit();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState) Hide();
        }

        private void databasePropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabasePropertiesForm i = new DatabasePropertiesForm();
            i.ShowDialog();
        }

        private void InOutButton_Click(object sender, EventArgs e)
        {            
            SwitchForm(DisplayForm.InOutBoard);
        }

        private void EditCategoriesMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesForm i = new CategoriesForm();
            i.ShowDialog();
        }

        private void ContactsButton_Click(object sender, EventArgs e)
        {
            SwitchForm(DisplayForm.Contacts);
        }

        private void SwitchForm(DisplayForm dform)
        {
            _contactsForm.Hide();
            _inOutForm.Hide();

            switch (dform)
            {
                case DisplayForm.Contacts:
                    _contactsForm.SwitchTo();
                    break;
                case DisplayForm.InOutBoard:
                    _inOutForm.SwitchTo();
                    break;
            }
        }

        private void sendMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageForm i = new MessageForm();
            i.NewMessage();
        }

        private void DisplayReceivedMessage(int messageID)
        {
            MessageForm m = new MessageForm();
            m.DisplayMessage(messageID);
        }

        private void messageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageHistoryForm m = new MessageHistoryForm();
            m.ShowDialog();
        }

        private void RemoteCommands(string[] args)
        {            
            if (args.Length != 0)
            {
                switch (args[0])
                {
                    case "NewMessage":
                        if (ABCUtilities.UsingServer)
                        {
                            MessageForm i = new MessageForm();
                            i.NewMessage();
                        }
                        break;
                    case "MessageHistory":
                        if (ABCUtilities.UsingServer)
                        {
                            MessageHistoryForm m = new MessageHistoryForm();
                            m.ShowDialog();
                        }
                        break;
                    case "Open":
                        notifyIcon.Visible = true;                        
                        this.TopLevel = true;                        
                        this.Show();
                        this.WindowState = FormWindowState.Maximized;
                        break;
                    default:
                        break;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized; 
        }

        private void whosOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FbDatabaseInfo dinfo = new FbDatabaseInfo(ABCUtilities.DataConnection);
            ArrayList ulist = dinfo.ActiveUsers;
            string userList = "Currently online users:\n";

            for (int i = 0; i < ulist.Count; i++)
            {
                userList += ulist[i] + "\n";
            }

            MessageBox.Show(userList);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.FileName = "abc_export.csv";
            sd.AddExtension = true;
            sd.DefaultExt = "*.csv";            
            sd.Title = "Export Data";
            sd.OverwritePrompt = true;
            sd.Filter = "Comma-separated values (*.csv)|*.csv|Text File (*.txt)|*.txt|XML File (*.xml)|*.xml";
            DialogResult d = sd.ShowDialog();
            if (d == DialogResult.Cancel) { return; }            

            FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
            fbcmd.CommandText = "SELECT NAME, TELEPHONE, FACSIMILE, MOBILE, ADDRESS, SUBURB, STATE, POST_CODE, WEBSITE, EMAIL, POSTAL_ADDRESS, POSTAL_SUBURB, POSTAL_STATE, POSTAL_POST_CODE, ENTRY_DATE, NOTES, (SELECT CATEGORY FROM CATEGORIES WHERE CATEGORIES.CATEGORY_ID = CONTACTS.CATEGORY) AS CATEGORY FROM CONTACTS;";
            FbDataReader reader = fbcmd.ExecuteReader();
            DataTable data;

            switch (sd.FilterIndex)
            {
                case 1:
                    data = new DataTable();
                    data.Load(reader);
                    ExportCSVDataTable(sd.FileName, data);
                    break;
                
                case 2:
                    data = new DataTable();
                    data.Load(reader);
                    ExportCSVDataTable(sd.FileName, data);
                    break;
                
                case 3:
                    data = new DataTable();
                    data.Load(reader);
                    data.WriteXml(sd.FileName);
                    break;

                default:                    
                    break;
            }
        }

        private void ExportCSVDataTable(String fileName, DataTable data)
        {            
            StreamWriter sw = new StreamWriter(fileName, false, Encoding.ASCII);
            for (int i = 0; i < data.Columns.Count; i++)
            {
                if (i == 0) { sw.Write("\"" + data.Columns[i].ColumnName + "\""); }
                else { sw.Write(",\"" + data.Columns[i].ColumnName + "\""); }
            }
            sw.Write("\r\n");

            foreach (DataRow r in data.Rows)
            {
                for (int x = 0; x < data.Columns.Count; x++)
                {
                    if (x == 0) { sw.Write("\"" + r[x].ToString() + "\""); }
                    else { sw.Write(",\"" + EscapeCSV(r[x].ToString()) + "\""); }
                }
                sw.Write("\r\n");
                
            }
            sw.Close();
        }

        private void ExportHTMLDataTable(String fileName, DataTable data)
        {            
            StreamWriter sw = new StreamWriter(fileName, false, Encoding.ASCII);

            for (int i = 0; i < data.Columns.Count; i++)
            {
                if (i == 0) { sw.Write("\"" + data.Columns[i].ColumnName + "\""); }
                else { sw.Write(",\"" + data.Columns[i].ColumnName + "\""); }
            }
            sw.Write("\r\n");

            foreach (DataRow r in data.Rows)
            {
                for (int x = 0; x < data.Columns.Count; x++)
                {
                    if (x == 0) { sw.Write("\"" + r[x].ToString() + "\""); }
                    else { sw.Write(",\"" + EscapeCSV(r[x].ToString()) + "\""); }
                }
                sw.Write("\r\n");

            }
            sw.Close();
        }

        private String EscapeCSV(String s)
        {
            String newString = s.Replace("\"", "\"\"");
            newString = s.Replace("\r\n", "\\r\\n");
            return newString;
        }

        private void printAddressBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
            fbcmd.CommandText = "SELECT NAME, TELEPHONE, FACSIMILE, MOBILE FROM CONTACTS ORDER BY NAME ASC;";
            FbDataReader reader = fbcmd.ExecuteReader();
            DataSet rDataSet = new DataSet();
            DataTable rTable = new DataTable();
            rTable.Load(reader);
            rTable.TableName = "Contact";
            rDataSet.Tables.Add(rTable);
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "ReportData_Contact";
            rds.Value = rDataSet.Tables[0];
            ReportViewForm.ViewReport(rds, "ABCAddressBook.ContactListReport.rdlc");
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Help.ShowHelp(this, Application.StartupPath + "\\AddressBook.chm");
        }

        private void RegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForm r = new RegisterForm();
            r.ShowDialog();
            DisplayRegistered();
        }

        private void StartupStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            SetAutoStart(StartupStripMenuItem.Checked);
        }

        private bool IsAutoStart()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
            if (key != null)
            {
                string r = (string)key.GetValue("ABCAddressBook");
                if (r != null) { return true; }
                else { return false; }
            }
            return false;
        }

        private void SetAutoStart(bool set)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (key != null)
            {
                if (set) { key.SetValue("ABCAddressBook", Application.ExecutablePath); }
                else 
                {
                    if (key.GetValue("ABCAddressBook") != null) { key.DeleteValue("ABCAddressBook"); }
                }
            }
        }

        private void MinimiseStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            ABCUtilities.SetRegistryValueBool("HideOnStart", MinimiseStripMenuItem.Checked);
        }
    }
}