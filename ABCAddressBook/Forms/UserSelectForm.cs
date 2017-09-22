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
    public partial class UserSelectForm : Form
    {
        private UserSelectResult _result = new UserSelectResult();

        public UserSelectForm()
        {
            InitializeComponent();
        }

        private void UserSelectForm_Load(object sender, EventArgs e)
        {
            ListUsers();
            _result.OKButton = false;
        }

        private void ListUsers()
        {
            FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
            fbcmd.CommandText = "SELECT USERNAME, SCREENNAME FROM MESSAGE_USERS ORDER BY SCREENNAME ASC;";
            FbDataReader fread = fbcmd.ExecuteReader();

            while (fread.Read())
            {
                MessageUser m = new MessageUser();
                m.UserName =  fread.GetString(fread.GetOrdinal("USERNAME"));
                m.ScreenName = fread.GetString(fread.GetOrdinal("SCREENNAME"));
                UserList.Items.Add(m);
            }                       
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            _result.OKButton = true;
                        
            for (int x = 0; x < UserList.CheckedItems.Count; x++ )
            { _result.SelectedUsers.Add(UserList.CheckedItems[x]); }

            this.Close();
        }

        private void UCancelButton_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        public static UserSelectResult ShowUsersDialog()
        {
            UserSelectForm i = new UserSelectForm();
            i.ShowDialog();
            return i._result;
        }

        private void TestButton_Click(object sender, EventArgs e)
        {            
        }
    }
}