using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABCAddressBook
{
    public partial class DatabasePropertiesForm : Form
    {
        public DatabasePropertiesForm()
        {
            InitializeComponent();
        }

        private void DatabaseProperties_Load(object sender, EventArgs e)
        {            
            ConnectionTypeCombo.Text = ABCUtilities.GetRegistryValue("ConnectionType");
            if (ABCUtilities.GetRegistryValue("ConnectionType") == "") { ConnectionTypeCombo.Text = "Local File"; }

            ServerText.Text = ABCUtilities.GetRegistryValue("Server");
            DatabaseText.Text = ABCUtilities.GetRegistryValue("Database");
            UserNameText.Text = ABCUtilities.GetRegistryValue("UserName").ToUpper();
            PasswordText.Text = ABCUtilities.GetRegistryValue("Password");
            AutoLoginCheck.Checked = ABCUtilities.GetRegistryValueBool("AutoLogin");
            ConnectionTypeCombo_SelectedIndexChanged(this, new EventArgs());
        }

        private void SaveSettings()
        {
            ABCUtilities.SetRegistryValue("ConnectionType", ConnectionTypeCombo.Text);
            ABCUtilities.SetRegistryValue("Server", ServerText.Text);
            ABCUtilities.SetRegistryValue("Database", DatabaseText.Text);
            ABCUtilities.SetRegistryValue("UserName", UserNameText.Text.ToUpper());
            ABCUtilities.SetRegistryValue("Password", PasswordText.Text);
            ABCUtilities.SetRegistryValueBool("AutoLogin", AutoLoginCheck.Checked);
        }

        private void DBCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();            
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (ConnectionTypeCombo.SelectedIndex == 1) //Local File
            {
                if (DatabaseText.Text.Length == 0) 
                { 
                    MessageBox.Show("You must enter the database path in the database field.", Application.ProductName); 
                    valid = false;                    
                }
            }
            else
            {
                if (ServerText.Text.Length == 0) 
                { 
                    MessageBox.Show("You must enter a server address in the server field. And IP address or host name.", Application.ProductName); 
                    valid = false;                    
                }
                
                if (DatabaseText.Text.Length == 0) 
                { 
                    MessageBox.Show("You must enter the database path on the server in the database field.", Application.ProductName);
                    valid = false;                    
                }
            }

            if (valid)
            {
                this.DialogResult = DialogResult.OK;
                SaveSettings();
                this.Close();
            }
        }

        private void ConnectionTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConnectionTypeCombo.SelectedIndex == 1)
            {
                AutoLoginCheck.Checked = true;
                AutoLoginCheck.Enabled = false;
                UserNameText.Text = "SYSDBA";
                UserNameText.Enabled = false;
                PasswordText.Text = "masterkey";
                PasswordText.Enabled = false;
                ServerText.Enabled = false;
            }
            else
            {
                ServerText.Enabled = true;
                AutoLoginCheck.Enabled = true;
                AutoLoginCheck_CheckedChanged(this, new EventArgs());
            }
        }

        private void AutoLoginCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoLoginCheck.Checked == false)
            {
                UserNameText.Enabled = false;
                PasswordText.Enabled = false;
            }
            else
            {
                UserNameText.Enabled = true;
                PasswordText.Enabled = true;
            }
        }
    }
}