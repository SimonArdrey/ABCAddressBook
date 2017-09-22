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
    public partial class InOutBoardForm : Form
    {
        private enum StaffStatus { In = 0, Away = 1, Out = 2 };
        private string[] StaffStatusText = new string[] {"IN", "AWAY", "OUT"};

        public InOutBoardForm()
        {
            InitializeComponent();
        }

        private void InOutBoardForm_Load(object sender, EventArgs e)
        {
            StaffList.HotTracking = false;
            StaffList.HoverSelection = false;
            SetupInOutButtons();
        }

        private void ListStaff()
        {
            DateTime currentDateTime = ABCUtilities.GetServerTime();
            StaffList.SuspendLayout();
            ArrayList itemsList = new ArrayList();
            ListViewItem[] itemsArray;

            FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
            fbcmd.CommandText = "SELECT NAME, STATUS, CHANGE_TIME, REASON, START_TIME FROM STAFF ORDER BY NAME";
            FbDataReader reader = fbcmd.ExecuteReader();
            
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(new string[] { reader.GetString(reader.GetOrdinal("NAME")), reader.GetString(reader.GetOrdinal("STATUS")), reader.GetDateTime(reader.GetOrdinal("CHANGE_TIME")).ToString(), reader.GetString(reader.GetOrdinal("REASON")), reader.GetString(reader.GetOrdinal("START_TIME"))});
                item.Name = reader.GetString(reader.GetOrdinal("NAME"));
                item.Tag = reader.GetString(reader.GetOrdinal("NAME"));
                item.UseItemStyleForSubItems = false;
                
                switch (reader.GetString(reader.GetOrdinal("STATUS")))
                {
                    case "IN":
                        item.SubItems[1].ForeColor = Color.White;
                        item.SubItems[1].BackColor = Color.DarkGreen;
                        break;
                    case "AWAY":
                        item.SubItems[1].ForeColor = Color.White;
                        item.SubItems[1].BackColor = Color.DarkRed;
                        break;
                    case "OUT":
                        item.SubItems[1].ForeColor = Color.White;
                        item.SubItems[1].BackColor = Color.DarkBlue;
                        break;
                }

                if (reader.GetDateTime(reader.GetOrdinal("CHANGE_TIME")).Date < currentDateTime.Date)
                {
                    item.SubItems[2].ForeColor = Color.White;
                    item.SubItems[2].BackColor = Color.Red;                    
                }
                else { item.SubItems[2].ForeColor = Color.DarkGreen; }

                if (reader.GetDateTime(reader.GetOrdinal("START_TIME")).Date < currentDateTime.Date)
                {
                    item.SubItems[4].Text = "---";
                    item.SubItems[4].ForeColor = Color.Red;                    
                }
                else { item.SubItems[4].ForeColor = Color.DarkGreen; }

                itemsList.Add(item);
            }            

            itemsArray = (ListViewItem[])itemsList.ToArray(typeof(ListViewItem));
            StaffList.Items.Clear();
            StaffList.Items.AddRange(itemsArray);
            StaffList.ResumeLayout();            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            InputBoxResult result = InputBoxForm.InputBox("Enter staff name.", "In / Out Board");
            if (result.OK)
            {
                FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
                fbcmd.CommandText = "INSERT INTO STAFF (NAME, STATUS, CHANGE_TIME, REASON, START_TIME) VALUES (@NAME, 'AWAY', CURRENT_TIMESTAMP, '', CURRENT_TIMESTAMP)";
                fbcmd.Parameters.Add("@NAME", ABCUtilities.EscapeString(result.InputText));                
                fbcmd.ExecuteNonQuery();                
                ListStaff();
            }            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (StaffList.SelectedItems.Count == 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + StaffList.SelectedItems[0].Text + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
                    fbcmd.CommandText = "DELETE FROM STAFF WHERE NAME = @NAME";
                    fbcmd.Parameters.Add("@NAME", ABCUtilities.EscapeString(StaffList.SelectedItems[0].Text));

                    try { fbcmd.ExecuteNonQuery(); }
                    catch (FbException ex)
                    {
                        if (ex.ErrorCode == -2147467259)
                        {
                            MessageBox.Show("You do not have permission to delete staff.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                    

                    StaffList.Items.Remove(StaffList.SelectedItems[0]);
                }
            }
        }

        private void InButton_ButtonClick(object sender, EventArgs e)
        {
            if (StaffList.SelectedItems.Count == 1)
            { SetStatus(StaffList.SelectedItems[0].Text, StaffStatus.In, ""); }
            else { MessageBox.Show("Please select a person.", "In / Out Board"); }
        }

        private void SetStatus(string name, StaffStatus status, string reason)
        {
            FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
            fbcmd.CommandText = "UPDATE STAFF SET STATUS = @STATUS, REASON = @REASON WHERE NAME = @NAME";
            fbcmd.Parameters.Add("@NAME", ABCUtilities.EscapeString(name));
            fbcmd.Parameters.Add("@STATUS", ABCUtilities.EscapeString(StaffStatusText[(int)status]));
            fbcmd.Parameters.Add("@REASON", ABCUtilities.EscapeString(reason));
            fbcmd.ExecuteNonQuery();            
            
            ListStaff();
            StaffList.Items[name].Selected = true;
        }

        private void SetStartTime(string name, DateTime startTime)
        {
            FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
            fbcmd.CommandText = "UPDATE STAFF SET START_TIME = @START_TIME WHERE NAME = @NAME";
            fbcmd.Parameters.Add("@NAME", ABCUtilities.EscapeString(name));
            fbcmd.Parameters.Add("@START_TIME", startTime);
            fbcmd.ExecuteNonQuery();

            ListStaff();
            StaffList.Items[name].Selected = true;
        }

        private void AwayButton_ButtonClick(object sender, EventArgs e)
        {
            if (StaffList.SelectedItems.Count == 1)
            {
                InputBoxResult result = InputBoxForm.InputBox("Enter a reason.", "In / Out Board");
                if (result.OK) { SetStatus(StaffList.SelectedItems[0].Text, StaffStatus.Away, result.InputText); }
            }
            else { MessageBox.Show("Please select a person.", "In / Out Board"); }
        }

        private void OutButton_ButtonClick(object sender, EventArgs e)
        {
            if (StaffList.SelectedItems.Count == 1)
            {
                InputBoxResult result = InputBoxForm.InputBox("Enter a reason.", "In / Out Board");
                if (result.OK) { SetStatus(StaffList.SelectedItems[0].Text, StaffStatus.Out, result.InputText); }
            }
            else { MessageBox.Show("Please select a person.", "In / Out Board"); }
        }

        private void setStartTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StaffList.SelectedItems.Count == 1)
            {
                DateTime current = ABCUtilities.GetServerTime();
                DateTimeInputResult stime = DateTimeInputForm.InputBox("Please enter a start time.", "In/Out Board", current);
                if (stime.OK)
                {
                    SetStartTime(StaffList.SelectedItems[0].Text, stime.SelectedDateTime);
                }
            }
            else { MessageBox.Show("Please select a person.", "In / Out Board"); }
        }

        private void OutButton_ItemClick(object sender, EventArgs e)
        {
            if (StaffList.SelectedItems.Count == 1)
            { SetStatus(StaffList.SelectedItems[0].Text, StaffStatus.Out, ((ToolStripMenuItem)sender).Text); }
            else { MessageBox.Show("Please select a person.", "In / Out Board"); }
        }

        private void AwayButton_ItemClick(object sender, EventArgs e)
        {
            if (StaffList.SelectedItems.Count == 1)
            { SetStatus(StaffList.SelectedItems[0].Text, StaffStatus.Away, ((ToolStripMenuItem)sender).Text); }
            else { MessageBox.Show("Please select a person.", "In / Out Board"); }
        }

        public void SwitchTo()
        {
            this.WindowState = FormWindowState.Maximized;
            ListStaff();
            this.Show();
        }

        private void SetupInOutButtons()
        {
            OutButton.DropDownItems.Clear();
            string[] outList = ABCUtilities.GetDataConfig("OutButtonList").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string i in outList) { OutButton.DropDownItems.Add(i, null, new EventHandler(OutButton_ItemClick)); }
            OutButton.DropDownItems.Add(new ToolStripSeparator());
            OutButton.DropDownItems.Add("Change Default Items", null, new EventHandler(ChangeOutButton_Click));            

            AwayButton.DropDownItems.Clear();
            string[] awayList = ABCUtilities.GetDataConfig("AwayButtonList").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string i in awayList) { AwayButton.DropDownItems.Add(i, null, new EventHandler(AwayButton_ItemClick)); }
            AwayButton.DropDownItems.Add(new ToolStripSeparator());
            AwayButton.DropDownItems.Add("Change Default Items", null, new EventHandler(ChangeAwayButton_Click));            
        }

        private void ChangeOutButton_Click(object sender, EventArgs e)
        {
            ListEditResult r = ListEditForm.ListEditBox("Change the default Out Button items. These can be seen by all users.", "Out Button Items", ABCUtilities.GetDataConfig("OutButtonList").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries));
            if (r.OK)
            {
                string serialString = "";
                foreach (string i in r.list) { serialString += i + ";"; }
                if (serialString.Length > 255)
                {
                    MessageBox.Show("Too many items or item character length too long.");
                }
                ABCUtilities.SaveDataConfig("OutButtonList", serialString);
                SetupInOutButtons();
            }
        }

        private void ChangeAwayButton_Click(object sender, EventArgs e)
        {
            ListEditResult r = ListEditForm.ListEditBox("Change the default Away Button items. These can be seen by all users.", "Away Button Items", ABCUtilities.GetDataConfig("AwayButtonList").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries));
            if (r.OK)
            {
                string serialString = "";
                foreach (string i in r.list) { serialString += i + ";"; }
                if (serialString.Length > 255)
                {
                    MessageBox.Show("Too many items or item character length too long.");
                }
                ABCUtilities.SaveDataConfig("AwayButtonList", serialString);
                SetupInOutButtons();
            }
        }
    }
}