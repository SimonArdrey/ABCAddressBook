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
    public partial class MessageHistoryForm : Form
    {
        public MessageHistoryForm()
        {
            InitializeComponent();
        }

        private void MessageHistoryForm_Load(object sender, EventArgs e)
        {
           DisplayMessages();
        }

        private void DisplayMessages()
        {
            ArrayList itemsList = new ArrayList();
            ListViewItem[] itemsArray;

            // Received Messages
            FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
            fbcmd.CommandText = "SELECT FIRST 100 MESSAGE_ID, MESSAGE_TO, MESSAGE_FROM, DETAILS, SIGNED, TELEPHONE, MOBILE, FAX, TELEPHONED, PLEASE_RING, WILL_RING_BACK, CALLED_IN, URGENT, DATE_TIME, (SELECT SCREENNAME FROM GET_SCREENNAME(SIGNED)) AS SCREENNAME FROM MESSAGES WHERE MESSAGE_TO = CURRENT_USER ORDER BY DATE_TIME DESC";
            FbDataReader reader = fbcmd.ExecuteReader();
            while (reader.Read())
            {
                string urgent = "";
                if (reader.GetInt16(reader.GetOrdinal("URGENT")) == 1)
                { urgent = "Yes"; } else { urgent = "No"; }
                
                string from = reader.GetString(reader.GetOrdinal("MESSAGE_FROM"));
                if (from.Length < 1)
                {
                    from = reader.GetString(reader.GetOrdinal("SCREENNAME")); ;
                }

                ListViewItem item = new ListViewItem(new string[] { from, reader.GetDateTime(reader.GetOrdinal("DATE_TIME")).ToString(), urgent, reader.GetString(reader.GetOrdinal("DETAILS")) });
                item.ImageIndex = 0;
                item.Tag = reader.GetInt32(reader.GetOrdinal("MESSAGE_ID"));
                item.UseItemStyleForSubItems = false;
                if (urgent == "Yes") { item.SubItems[2].ForeColor = Color.Red; }
                
                itemsList.Add(item);           
            }
            itemsArray = (ListViewItem[])itemsList.ToArray(typeof(ListViewItem));
            ReceivedList.Items.Clear();
            ReceivedList.Items.AddRange(itemsArray);



            // Sent Messages
            itemsList = new ArrayList();
            fbcmd = ABCUtilities.DataConnection.CreateCommand();
            fbcmd.CommandText = "SELECT FIRST 100 MESSAGE_ID, MESSAGE_TO, MESSAGE_FROM, DETAILS, SIGNED, TELEPHONE, MOBILE, FAX, TELEPHONED, PLEASE_RING, WILL_RING_BACK, CALLED_IN, URGENT, DATE_TIME, MESSAGE_READ, (SELECT SCREENNAME FROM GET_SCREENNAME(MESSAGE_TO)) AS SCREENNAME FROM MESSAGES WHERE SIGNED = CURRENT_USER ORDER BY DATE_TIME DESC";
            reader = fbcmd.ExecuteReader();
            while (reader.Read())
            {

                string read = "";
                if (reader.GetInt16(reader.GetOrdinal("MESSAGE_READ")) == 1)
                { read = "Yes"; }
                else { read = "No"; }

                ListViewItem item = new ListViewItem(new string[] { reader.GetString(reader.GetOrdinal("SCREENNAME")), reader.GetDateTime(reader.GetOrdinal("DATE_TIME")).ToString(), read, reader.GetString(reader.GetOrdinal("DETAILS")) });
                item.ImageIndex = 0;
                item.Tag = reader.GetInt32(reader.GetOrdinal("MESSAGE_ID"));
                item.UseItemStyleForSubItems = false;
                if (read == "No") { item.SubItems[2].ForeColor = Color.Red; }

                itemsList.Add(item);
            }
            itemsArray = (ListViewItem[])itemsList.ToArray(typeof(ListViewItem));
            SentList.Items.Clear();
            SentList.Items.AddRange(itemsArray);        
        
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReceivedList_DoubleClick(object sender, EventArgs e)
        {
            if (ReceivedList.SelectedItems.Count > 0)
            {
                MessageForm m = new MessageForm();
                m.ViewMessage((int)ReceivedList.SelectedItems[0].Tag);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            DisplayMessages();
        }

        private void SentList_DoubleClick(object sender, EventArgs e)
        {
            if (SentList.SelectedItems.Count > 0)
            {
                MessageForm m = new MessageForm();
                m.ViewMessage((int)SentList.SelectedItems[0].Tag);
            }
        }
    }
}