using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using FirebirdSql.Data.FirebirdClient;
using System.Threading;
using System.Data;
using System.Diagnostics;

namespace ABCImport
{
    public static class Program
    {
        private const string WindowTitle = "ABC Address Book";
        private const string ConsoleTitle = "ABC Address Book Import Tool";

        public static FbConnection FbDataConnection;
        private const string FbConString = "User=SYSDBA;Password=blah;Database=/home/sirco/firebird_data/ABCAddressBook.fdb;Server=server;Port=3050;Dialect=3;Charset=ISO8859_1;";

        public static MySqlConnection MySqlDataConnection;
        private const string MySqlConString = "DATABASE=abc_addressbook;SERVER=server;UID=root;Password=blah;";

        static void Main(string[] args)
        {
            PrintTitle();
            ConnectToDatabase();
            MergeCategorys();
            MergeContacts();
            MergeMessages();
            MergeStaff();
            Console.WriteLine("Merge Completed!");
            Pause();
            //while (true) { MainMenu(); }
        }

        private static void PrintStatus(string title, bool status)
        {
            if (title.Length > (Console.BufferWidth / 2)) { title = title.Substring(0, Console.BufferWidth / 2); }
            title = title.PadRight(Console.BufferWidth / 2, ' ');
            title += "[";
            Console.Write(title);
            if (status)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  OK  ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" FAIL ");
            }
            Console.ResetColor();
            Console.WriteLine("]");
        }

        private static void PrintPercent(string title, double percent)
        {
            int currentx = Console.CursorLeft;
            int currenty = Console.CursorTop;

            if (title.Length > (Console.BufferWidth / 2)) { title = title.Substring(0, Console.BufferWidth / 2); }
            title = title.PadRight(Console.BufferWidth / 2, ' ');
            title += "[";
            Console.Write(title);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" " + (int)percent + "% ");
            Console.ResetColor();
            Console.Write("]");
            Console.CursorLeft = currentx;
            Console.CursorTop = currenty;
        }

        private static void DebugMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Debug: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void PrintTitle()
        {
            Console.Title = Program.WindowTitle;
            Console.Clear();

            string title = Program.ConsoleTitle;
            title = title.PadRight(Console.BufferWidth, ' ');
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(title);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ResetColor();
        }

        private static void Pause()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        private static void Pause(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        private static void Quit()
        {
            Console.Clear();
            Thread.CurrentThread.Abort();
        }

        private static void ConnectToDatabase()
        {
            FbDataConnection = new FbConnection(FbConString);
            MySqlDataConnection = new MySqlConnection(MySqlConString);

            try { FbDataConnection.Open(); }
            catch (FbException ex)
            {
                PrintStatus("FirebirdSql Connection", false);
                Pause("Press any key to exit.");
                Quit();
            }
            PrintStatus("FirebirdSql Connection", true);

            try { MySqlDataConnection.Open(); }
            catch (MySqlException ex)
            {
                PrintStatus("MySql Connection", false);
                Pause("Press any key to exit.");
                Quit();
            }
            PrintStatus("MySql Connection", true);
        }

        private static TableCounts GetFirebirdTableCounts()
        {
            TableCounts counts = new TableCounts();
            FbCommand fbcmd = FbDataConnection.CreateCommand();
            fbcmd.CommandText = "SELECT (SELECT COUNT(*) FROM MESSAGE_USERS) AS MESSAGE_USERS, (SELECT COUNT(*) FROM STAFF) AS STAFF, (SELECT COUNT(*) FROM MESSAGES) AS MESSAGES, (SELECT COUNT(*) FROM CATEGORYS) AS CATEGORYS, COUNT(*) AS CONTACTS FROM CONTACTS";
            FbDataReader reader = fbcmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                counts.Contacts = reader.GetInt32(reader.GetOrdinal("CONTACTS"));
                counts.Categorys  = reader.GetInt32(reader.GetOrdinal("CATEGORYS"));
                counts.Messages = reader.GetInt32(reader.GetOrdinal("MESSAGES"));
                counts.MessageUsers = reader.GetInt32(reader.GetOrdinal("MESSAGE_USERS"));
                counts.Staff = reader.GetInt32(reader.GetOrdinal("STAFF"));
            }
            reader.Close();
            return counts;
        }

        private static TableCounts GetMySqlTableCounts()
        {
            TableCounts counts = new TableCounts();
            MySqlCommand mycmd = MySqlDataConnection.CreateCommand();
            mycmd.CommandText = "SELECT (SELECT COUNT(*) FROM message_users) AS MESSAGE_USERS, (SELECT COUNT(*) FROM staff) AS STAFF, (SELECT COUNT(*) FROM messages) AS MESSAGES, (SELECT COUNT(*) FROM categorys) AS CATEGORYS, COUNT(*) AS CONTACTS FROM contacts";
            MySqlDataReader reader = mycmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                counts.Contacts = reader.GetInt32(reader.GetOrdinal("CONTACTS"));
                counts.Categorys = reader.GetInt32(reader.GetOrdinal("CATEGORYS"));
                counts.Messages = reader.GetInt32(reader.GetOrdinal("MESSAGES"));
                counts.MessageUsers = reader.GetInt32(reader.GetOrdinal("MESSAGE_USERS"));
                counts.Staff = reader.GetInt32(reader.GetOrdinal("STAFF"));
            }
            reader.Close();
            return counts;
        }

        private static void MainMenu()
        {
            PrintTitle();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter menu item.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Merge Categorys");
            Console.WriteLine("2) Merge Contacts");
            Console.WriteLine("3) Merge Messages");
            Console.WriteLine("4) Merge Staff");
            Console.WriteLine("5) Merge All");
            Console.WriteLine("Q) Exit");
            Console.ResetColor();

            ConsoleKeyInfo mkey = Console.ReadKey(true);

            switch (mkey.Key)
            {
                case ConsoleKey.D1: // Merge Categorys
                    MergeCategorys();
                    Pause();
                    break;
                case ConsoleKey.D2: // Merge Contacts
                    MergeContacts();
                    Pause();
                    break;
                case ConsoleKey.D3: // Merge Messages
                    MergeMessages();
                    Pause();
                    break;
                case ConsoleKey.D4: // Merge Staff
                    MergeStaff();
                    Pause();
                    break;
                case ConsoleKey.D5: // Merge All
                    MergeCategorys();
                    MergeContacts();
                    MergeMessages();
                    Pause();
                    break;
                case ConsoleKey.Q: // Quit
                    Quit();
                    break;
                default:
                    break;
            }
        }

        private static void MergeCategorys()
        {
            TableCounts counts = GetMySqlTableCounts();
            int count = 0;
            double percent = 0;
            string statement = "INSERT INTO CATEGORYS VALUES (@ID, @CATEGORY)";

            FbCommand fbcmd = FbDataConnection.CreateCommand();
            fbcmd.CommandText = "DELETE FROM CATEGORYS";
            fbcmd.ExecuteNonQuery();

            MySqlCommand mycmd = MySqlDataConnection.CreateCommand();
            mycmd.CommandText = "SELECT Category, ID FROM categorys";
            MySqlDataReader reader = mycmd.ExecuteReader();
            while (reader.Read())
            {
                string newStatement = statement;
                fbcmd = FbDataConnection.CreateCommand();
                fbcmd.CommandText = newStatement;
                fbcmd.Parameters.Add("@ID", reader.GetInt32(reader.GetOrdinal("ID")).ToString());
                fbcmd.Parameters.Add("@CATEGORY", EscapeString(reader.GetString(reader.GetOrdinal("Category"))));

                try { fbcmd.ExecuteNonQuery(); }
                catch
                {
                    PrintStatus("Merge Categorys", false);
                    return;
                }
                count++;
                percent = ((double)count / (double)counts.Categorys) * 100;
                PrintPercent("Merge Categorys", percent);
            }
            reader.Close();

            fbcmd = FbDataConnection.CreateCommand();
            fbcmd.CommandText = "SELECT CATEGORY_ID FROM CATEGORYS ORDER BY CATEGORY_ID DESC ROWS 1";
            FbDataReader fbreader = fbcmd.ExecuteReader();
            if (fbreader.HasRows)
            {
                fbreader.Read();
                int lastID = fbreader.GetInt32(fbreader.GetOrdinal("CATEGORY_ID"));
                fbcmd = FbDataConnection.CreateCommand();
                fbcmd.CommandText = "SET GENERATOR CATEGORYS_CATEGORY_ID_GEN TO " + lastID;
                fbcmd.ExecuteNonQuery();
                fbreader.Close();
            }
            else
            {
                PrintStatus("Merge Categorys", false);
                return;
            }

            PrintStatus("Merge Categorys", true);
        }

        private static void MergeContacts()
        {
            TableCounts counts = GetMySqlTableCounts();
            int count = 0;
            double percent = 0;
            string statement = "INSERT INTO CONTACTS (CONTACT_ID, NAME, TELEPHONE, FACSIMILE, MOBILE, ADDRESS, SUBURB, STATE, POST_CODE, WEBSITE, EMAIL, POSTAL_ADDRESS, POSTAL_SUBURB, POSTAL_STATE, POSTAL_POST_CODE, CATEGORY, ENTRY_DATE, NOTES) VALUES (@CONTACT_ID, '@NAME', '@TELEPHONE', '@FACSIMILE', '@MOBILE', '@ADDRESS', '@SUBURB', '@STATE', '@POST_CODE', '@WEBSITE', '@EMAIL', '@POSTAL_ADDRESS', '@POSTAL_SUBURB', '@POSTAL_STATE', '@POSTAL_POST_CODE', @CATEGORY, '@ENTRY_DATE', '@NOTES')";

            FbCommand fbcmd = FbDataConnection.CreateCommand();
            fbcmd.CommandText = "DELETE FROM CONTACTS";
            fbcmd.ExecuteNonQuery();

            MySqlCommand mycmd = MySqlDataConnection.CreateCommand();
            mycmd.CommandText = "select ID, Postal_Address, Postal_Suburb, Postal_State, Postal_Post_Code, Notes, State, (select category from categorys where id = c.category) CategoryName, Category, Name, Telephone, Facsimile, Mobile, Email, Website, Address, Suburb, Post_Code, Entry_Date from contacts c";
            MySqlDataReader reader = mycmd.ExecuteReader();
            while (reader.Read())
            {
                string newStatement = statement;
                fbcmd = FbDataConnection.CreateCommand();
                fbcmd.CommandText = newStatement;
                fbcmd.CommandText = fbcmd.CommandText.Replace("@CONTACT_ID", reader.GetInt32(reader.GetOrdinal("ID")).ToString());
                fbcmd.CommandText = fbcmd.CommandText.Replace("@CATEGORY", reader.GetInt32(reader.GetOrdinal("Category")).ToString());
                fbcmd.CommandText = fbcmd.CommandText.Replace("@NAME", EscapeString(reader.GetString(reader.GetOrdinal("Name"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@TELEPHONE", EscapeString(reader.GetString(reader.GetOrdinal("Telephone"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@FACSIMILE", EscapeString(reader.GetString(reader.GetOrdinal("Facsimile"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@MOBILE", EscapeString(reader.GetString(reader.GetOrdinal("Mobile"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@EMAIL", EscapeString(reader.GetString(reader.GetOrdinal("Email"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@WEBSITE", EscapeString(reader.GetString(reader.GetOrdinal("Website"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@ADDRESS", EscapeString(reader.GetString(reader.GetOrdinal("Address"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@SUBURB", EscapeString(reader.GetString(reader.GetOrdinal("Suburb"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@STATE", EscapeString(reader.GetString(reader.GetOrdinal("State"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@POST_CODE", EscapeString(reader.GetString(reader.GetOrdinal("Post_Code"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@POSTAL_ADDRESS", EscapeString(reader.GetString(reader.GetOrdinal("Postal_Address"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@POSTAL_SUBURB", EscapeString(reader.GetString(reader.GetOrdinal("Postal_Suburb"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@POSTAL_STATE", EscapeString(reader.GetString(reader.GetOrdinal("Postal_State"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@POSTAL_POST_CODE", EscapeString(reader.GetString(reader.GetOrdinal("Postal_Post_Code"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@NOTES", EscapeString(reader.GetString(reader.GetOrdinal("Notes"))));
                string newdate = reader.GetDateTime(reader.GetOrdinal("Entry_Date")).Day.ToString() + "." + reader.GetDateTime(reader.GetOrdinal("Entry_Date")).Month.ToString() + "." + reader.GetDateTime(reader.GetOrdinal("Entry_Date")).Year.ToString();;
                fbcmd.CommandText = fbcmd.CommandText.Replace("@ENTRY_DATE", newdate);

                try { fbcmd.ExecuteNonQuery(); }
                catch
                {
                    PrintStatus("Merge Contacts", false);
                    return;
                }

                count++;
                percent = ((double)count / (double)counts.Contacts) * 100;
                PrintPercent("Merge Contacts", percent);
            }
            reader.Close();

            fbcmd = FbDataConnection.CreateCommand();
            fbcmd.CommandText = "SELECT CONTACT_ID FROM CONTACTS ORDER BY CONTACT_ID DESC ROWS 1";
            FbDataReader fbreader = fbcmd.ExecuteReader();
            if (fbreader.HasRows)
            {
                fbreader.Read();
                int lastID = fbreader.GetInt32(fbreader.GetOrdinal("CONTACT_ID"));
                fbcmd = FbDataConnection.CreateCommand();
                fbcmd.CommandText = "SET GENERATOR CONTACTS_CONTACT_ID_GEN TO " + lastID;
                fbcmd.ExecuteNonQuery();
                fbreader.Close();
            }
            else
            {
                PrintStatus("Merge Categorys", false);
                return;
            }

            PrintStatus("Merge Contacts", true);
        }

        public static string EscapeString(string escapeString)
        {
            escapeString = escapeString.Replace("'", "''");
            return escapeString;
        }

        private static void MergeMessages()
        {
            TableCounts counts = GetMySqlTableCounts();
            int count = 0;
            double percent = 0;
            string statement = "INSERT INTO MESSAGES (MESSAGE_ID, MESSAGE_TO, MESSAGE_FROM, DETAILS, SIGNED, DATE_TIME, MOBILE, TELEPHONE, FAX, TELEPHONED, PLEASE_RING, WILL_RING_BACK, CALLED_IN, MESSAGE_READ, MESSAGE_DISPLAYED, URGENT) VALUES (@MESSAGE_ID, '@MESSAGE_TO', '@MESSAGE_FROM', '@DETAILS', '@SIGNED', '@DATE_TIME', '@MOBILE', '@TELEPHONE@', '@FAX', @TELEPHONED@, @PLEASE_RING, @WILL_RING_BACK, @CALLED_IN, @MESSAGE_READ, @MESSAGE_DISPLAYED, @URGENT);";

            FbCommand fbcmd = FbDataConnection.CreateCommand();
            fbcmd.CommandText = "DELETE FROM MESSAGES";
            fbcmd.ExecuteNonQuery();

            MySqlCommand mycmd = MySqlDataConnection.CreateCommand();
            mycmd.CommandText = "SELECT ID, Msg_To, Msg_From, Details, Signed, Date_Time, Telephone, Mobile, Fax, Telephoned, Please_Ring, Will_Ring_Back, Called_In, Msg_Read, Urgent, Msg_Displayed FROM messages";
            MySqlDataReader reader = mycmd.ExecuteReader();
            while (reader.Read())
            {
                string newStatement = statement;
                fbcmd = FbDataConnection.CreateCommand();
                fbcmd.CommandText = newStatement;
                fbcmd.CommandText = fbcmd.CommandText.Replace("@MESSAGE_ID", reader.GetInt32(reader.GetOrdinal("ID")).ToString());
                fbcmd.CommandText = fbcmd.CommandText.Replace("@MESSAGE_TO", EscapeString(reader.GetString(reader.GetOrdinal("Msg_To")).ToUpper()));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@MESSAGE_FROM", EscapeString(reader.GetString(reader.GetOrdinal("Msg_From"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@DETAILS", EscapeString(reader.GetString(reader.GetOrdinal("Details"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@SIGNED", EscapeString(reader.GetString(reader.GetOrdinal("Signed")).ToUpper()));
                string newdate = reader.GetDateTime(reader.GetOrdinal("Date_Time")).Day.ToString() + "." + reader.GetDateTime(reader.GetOrdinal("Date_Time")).Month.ToString() + "." + reader.GetDateTime(reader.GetOrdinal("Date_Time")).Year.ToString() + " " + reader.GetDateTime(reader.GetOrdinal("Date_Time")).Hour.ToString() + ":" + reader.GetDateTime(reader.GetOrdinal("Date_Time")).Minute.ToString() + ":" + reader.GetDateTime(reader.GetOrdinal("Date_Time")).Second.ToString();
                fbcmd.CommandText = fbcmd.CommandText.Replace("@DATE_TIME", newdate);
                fbcmd.CommandText = fbcmd.CommandText.Replace("@MOBILE", EscapeString(reader.GetString(reader.GetOrdinal("Mobile"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@TELEPHONE@", EscapeString(reader.GetString(reader.GetOrdinal("Telephone"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@FAX", EscapeString(reader.GetString(reader.GetOrdinal("Fax"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@TELEPHONED@", reader.GetByte(reader.GetOrdinal("Telephoned")).ToString());
                fbcmd.CommandText = fbcmd.CommandText.Replace("@PLEASE_RING", reader.GetByte(reader.GetOrdinal("Please_Ring")).ToString());
                fbcmd.CommandText = fbcmd.CommandText.Replace("@WILL_RING_BACK", reader.GetByte(reader.GetOrdinal("Will_Ring_Back")).ToString());
                fbcmd.CommandText = fbcmd.CommandText.Replace("@CALLED_IN", reader.GetByte(reader.GetOrdinal("Called_In")).ToString());
                fbcmd.CommandText = fbcmd.CommandText.Replace("@MESSAGE_READ", reader.GetByte(reader.GetOrdinal("Msg_Read")).ToString());
                fbcmd.CommandText = fbcmd.CommandText.Replace("@MESSAGE_DISPLAYED", reader.GetByte(reader.GetOrdinal("Msg_Displayed")).ToString());
                fbcmd.CommandText = fbcmd.CommandText.Replace("@URGENT", reader.GetByte(reader.GetOrdinal("Urgent")).ToString());

                //DebugMessage(fbcmd.CommandText);
                //fbcmd.ExecuteNonQuery();

                try { fbcmd.ExecuteNonQuery(); }
                catch
                {
                    PrintStatus("Merge Messages", false);
                    return;
                }

                count++;
                percent = ((double)count / (double)counts.Messages) * 100;
                PrintPercent("Merge Messages", percent);
            }
            reader.Close();

            fbcmd = FbDataConnection.CreateCommand();
            fbcmd.CommandText = "SELECT MESSAGE_ID FROM MESSAGES ORDER BY MESSAGE_ID DESC ROWS 1";
            FbDataReader fbreader = fbcmd.ExecuteReader();
            if (fbreader.HasRows)
            {
                fbreader.Read();
                int lastID = fbreader.GetInt32(fbreader.GetOrdinal("MESSAGE_ID"));
                fbcmd = FbDataConnection.CreateCommand();
                fbcmd.CommandText = "SET GENERATOR MESSAGES_MESSAGE_ID_GEN TO " + lastID;
                fbcmd.ExecuteNonQuery();
                fbreader.Close();
            }
            else
            {
                PrintStatus("Merge Messages", false);
                return;
            }

            PrintStatus("Merge Messages", true);
        }

        private static void MergeStaff()
        {
            TableCounts counts = GetMySqlTableCounts();
            int count = 0;
            double percent = 0;
            string statement = "INSERT INTO STAFF (NAME, STATUS, CHANGE_TIME, REASON, START_TIME) VALUES ('@NAME', '@STATUS', CURRENT_TIMESTAMP, '', CURRENT_TIMESTAMP)";

            FbCommand fbcmd = FbDataConnection.CreateCommand();
            fbcmd.CommandText = "DELETE FROM STAFF";
            fbcmd.ExecuteNonQuery();

            MySqlCommand mycmd = MySqlDataConnection.CreateCommand();
            mycmd.CommandText = "SELECT Name, Status, Change_Time, Reason FROM staff";
            MySqlDataReader reader = mycmd.ExecuteReader();
            while (reader.Read())
            {
                string newStatement = statement;
                fbcmd = FbDataConnection.CreateCommand();
                fbcmd.CommandText = newStatement;
                fbcmd.CommandText = fbcmd.CommandText.Replace("@NAME", EscapeString(reader.GetString(reader.GetOrdinal("Name"))));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@STATUS", EscapeString(reader.GetString(reader.GetOrdinal("Status")).ToUpper()));

                //DebugMessage(fbcmd.CommandText);
                //fbcmd.ExecuteNonQuery();

                try { fbcmd.ExecuteNonQuery(); }
                catch
                {
                    PrintStatus("Merge Staff", false);
                    return;
                }

                count++;
                percent = ((double)count / (double)counts.Staff) * 100;
                PrintPercent("Merge Staff", percent);
            }
            reader.Close();

            PrintStatus("Merge Staff", true);
        }

    }
}
