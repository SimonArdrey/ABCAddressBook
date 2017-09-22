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
    public partial class MessageForm : Form
    {
        private enum MessageMode
        {
            MessageNew = 1,
            MessageDisplay = 2,
            MessageView = 3
        };

        private int _messageID;        

        private ArrayList _users = new ArrayList();
        private MessageMode _mode;

        public MessageForm()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            switch (_mode)
            {
                case MessageMode.MessageNew:
                    SendMessage();
                    break;
                case MessageMode.MessageDisplay:
                    MessageForm m = new MessageForm();
                    m.ReplyMessage(SignedLabel.Text);
                    ABCUtilities.SetMessageRead(_messageID);
                    this.Close();
                    break;
            }            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {            
            switch (_mode)
            {
                case MessageMode.MessageNew:
                    this.Close();
                    break;
                case MessageMode.MessageDisplay:
                    ABCUtilities.SetMessageRead(_messageID);
                    this.Close();
                    break;
                case MessageMode.MessageView:
                    this.Close();
                    break;
            }
        }

        private void SendMessage()
        {
            if (_users.Count == 0) { MessageBox.Show("Please select one or more users to send the message to."); }
            else
            {
                foreach (MessageUser user in _users)
                {
                    FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
                    fbcmd.CommandType = CommandType.StoredProcedure;
                    fbcmd.CommandText = "SEND_MESSAGE";
                    fbcmd.Parameters.Add("@MESSAGE_TO", user.UserName);
                    fbcmd.Parameters.Add("@MESSAGE_FROM", FromText.Text);
                    fbcmd.Parameters.Add("@DETAILS", DetailsText.Text);
                    fbcmd.Parameters.Add("@TELEPHONE", TelephoneText.Text);
                    fbcmd.Parameters.Add("@MOBILE", MobileText.Text);
                    fbcmd.Parameters.Add("@FAX", FaxText.Text);
                    fbcmd.Parameters.Add("@TELEPHONED", CheckToInt(TelephonedCheck));
                    fbcmd.Parameters.Add("@PLEASE_RING", CheckToInt(PleaseRingCheck));
                    fbcmd.Parameters.Add("@WILL_RING_BACK", CheckToInt(WillRingBackCheck));
                    fbcmd.Parameters.Add("@CALLED_IN", CheckToInt(CalledInCheck));
                    fbcmd.Parameters.Add("@URGENT", CheckToInt(UrgentCheck));
                    fbcmd.ExecuteNonQuery();
                }

                string users = "";
                bool first = true;
                foreach (MessageUser user in _users)
                {                    
                    if (!ABCUtilities.IsUserOnline(user.UserName))
                    {                        
                        if (first)
                        {
                            users += user.ScreenName;
                            first = false;
                        }
                        else { users += ", " + user.ScreenName; }
                    }
                }

                if (users.Length > 0) { MessageBox.Show("The following users are currently not online and will receive the message when they next log on: " + System.Environment.NewLine + users, Application.ProductName); }

                this.Close();
            }            
        }

        private void SelectUsersButton_Click(object sender, EventArgs e)
        {
            if (_mode == MessageMode.MessageNew)
            {
                UserSelectResult i = UserSelectForm.ShowUsersDialog();
                _users = i.SelectedUsers;
                DisplayUsers();
            }
        }

        private void DisplayUsers()
        {
            ToLabel.Text = "";
            foreach (MessageUser m in _users)
            {
                ToLabel.Text += m.ScreenName + ", ";
            }
        }

        private ushort CheckToInt(CheckBox box)
        {
            if (box.Checked) { return 1; } else { return 0; }
        }

        private bool IntToBool(ushort status)
        {
            if (status == 1) { return true; } else { return false; }
        }

        public void NewMessage()
        {
            DateTime cDateTime = ABCUtilities.GetServerTime();
            _mode = MessageMode.MessageNew;
            DateLabel.Text = cDateTime.ToShortDateString();
            TimeLabel.Text = cDateTime.ToShortTimeString();
            SignedLabel.Text = ABCUtilities.GetUserName();
            CloseButton.Text = "&Cancel";
            this.Show();
        }

        public void ReplyMessage(string username)
        {
            DateTime cDateTime = ABCUtilities.GetServerTime();
            _mode = MessageMode.MessageNew;
            DateLabel.Text = cDateTime.ToShortDateString();
            TimeLabel.Text = cDateTime.ToShortTimeString();
            SignedLabel.Text = ABCUtilities.GetUserName();
            CloseButton.Text = "&Cancel";

            string screenname = ABCUtilities.GetScreenName(username);
            _users = new ArrayList();
            _users.Add(new MessageUser(username, screenname));

            this.Show();

            DisplayUsers();
        }

        public void DisplayMessage(int messageID)
        {
            _mode = MessageMode.MessageDisplay;
            _messageID = messageID;
            SendButton.Text = "&Reply";
            CloseButton.Text = "&Close";
            SelectUsersButton.Visible = false;

            FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
            fbcmd.CommandText = "SELECT MESSAGE_TO, MESSAGE_FROM, DETAILS, SIGNED, TELEPHONE, MOBILE, FAX, TELEPHONED, PLEASE_RING, WILL_RING_BACK, CALLED_IN, URGENT, DATE_TIME, (SELECT SCREENNAME FROM GET_SCREENNAME(CURRENT_USER)) AS MYSCREENNAME, (SELECT SCREENNAME FROM GET_SCREENNAME(SIGNED)) AS FROMSCREENNAME FROM MESSAGES WHERE MESSAGE_ID = @MESSAGE_ID";
            fbcmd.Parameters.Add("@MESSAGE_ID", messageID);
            FbDataReader reader = fbcmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                string from = reader.GetString(reader.GetOrdinal("MESSAGE_FROM"));
                if (from.Length < 1)
                { from = reader.GetString(reader.GetOrdinal("FROMSCREENNAME")); }
                this.Text += " [" + from + "]";

                FromText.Text = from;
                ToLabel.Text = reader.GetString(reader.GetOrdinal("MYSCREENNAME"));
                SignedLabel.Text = reader.GetString(reader.GetOrdinal("SIGNED"));                
                DetailsText.Text = reader.GetString(reader.GetOrdinal("DETAILS"));
                TelephoneText.Text = reader.GetString(reader.GetOrdinal("TELEPHONE"));
                FaxText.Text = reader.GetString(reader.GetOrdinal("FAX"));
                MobileText.Text = reader.GetString(reader.GetOrdinal("MOBILE"));
                
                TelephonedCheck.Checked = IntToBool((ushort)reader.GetInt16(reader.GetOrdinal("TELEPHONED")));
                PleaseRingCheck.Checked = IntToBool((ushort)reader.GetInt16(reader.GetOrdinal("PLEASE_RING")));
                WillRingBackCheck.Checked = IntToBool((ushort)reader.GetInt16(reader.GetOrdinal("WILL_RING_BACK")));
                CalledInCheck.Checked = IntToBool((ushort)reader.GetInt16(reader.GetOrdinal("CALLED_IN")));
                UrgentCheck.Checked = IntToBool((ushort)reader.GetInt16(reader.GetOrdinal("URGENT")));

                DateLabel.Text = reader.GetDateTime(reader.GetOrdinal("DATE_TIME")).ToShortDateString();
                TimeLabel.Text = reader.GetDateTime(reader.GetOrdinal("DATE_TIME")).ToShortTimeString(); ;              

                this.Show();
                ABCUtilities.SetMessageDisplayed(messageID);
            }
        }

        public void ViewMessage(int messageID)
        {
            _mode = MessageMode.MessageView;
            _messageID = messageID;
            SendButton.Visible = false;
            SelectUsersButton.Visible = false;
            CloseButton.Text = "&Close";            

            FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
            fbcmd.CommandText = "SELECT MESSAGE_TO, MESSAGE_FROM, DETAILS, SIGNED, TELEPHONE, MOBILE, FAX, TELEPHONED, PLEASE_RING, WILL_RING_BACK, CALLED_IN, URGENT, DATE_TIME, (SELECT SCREENNAME FROM GET_SCREENNAME(MESSAGE_TO)) AS TOSCREENNAME, (SELECT SCREENNAME FROM GET_SCREENNAME(SIGNED)) AS FROMSCREENNAME FROM MESSAGES WHERE MESSAGE_ID = @MESSAGE_ID";
            fbcmd.Parameters.Add("@MESSAGE_ID", messageID);
            FbDataReader reader = fbcmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                string from = reader.GetString(reader.GetOrdinal("MESSAGE_FROM"));
                if (from.Length < 1)
                { from = reader.GetString(reader.GetOrdinal("FROMSCREENNAME")); }
                this.Text += " [" + from + "]";

                FromText.Text = from;
                ToLabel.Text = reader.GetString(reader.GetOrdinal("TOSCREENNAME"));
                SignedLabel.Text = reader.GetString(reader.GetOrdinal("SIGNED"));
                DetailsText.Text = reader.GetString(reader.GetOrdinal("DETAILS"));
                TelephoneText.Text = reader.GetString(reader.GetOrdinal("TELEPHONE"));
                FaxText.Text = reader.GetString(reader.GetOrdinal("FAX"));
                MobileText.Text = reader.GetString(reader.GetOrdinal("MOBILE"));

                TelephonedCheck.Checked = IntToBool((ushort)reader.GetInt16(reader.GetOrdinal("TELEPHONED")));
                PleaseRingCheck.Checked = IntToBool((ushort)reader.GetInt16(reader.GetOrdinal("PLEASE_RING")));
                WillRingBackCheck.Checked = IntToBool((ushort)reader.GetInt16(reader.GetOrdinal("WILL_RING_BACK")));
                CalledInCheck.Checked = IntToBool((ushort)reader.GetInt16(reader.GetOrdinal("CALLED_IN")));
                UrgentCheck.Checked = IntToBool((ushort)reader.GetInt16(reader.GetOrdinal("URGENT")));

                DateLabel.Text = reader.GetDateTime(reader.GetOrdinal("DATE_TIME")).ToShortDateString();
                TimeLabel.Text = reader.GetDateTime(reader.GetOrdinal("DATE_TIME")).ToShortTimeString(); ;

                this.Show();                
            }
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {            
        }
    }
}