using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace ABCAddressBook
{
    public static class ABCLog
    {
        private static string _logFileName;
        private static TextWriter _logWriter;

        private static void ABCLogOpen()
        {
            _logFileName = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\" + Application.CompanyName + "\\" + Application.ProductName + "\\" + "ABCAddressBook.log";
            _logWriter = new StreamWriter(_logFileName, true);            
        }

        private static void ABCLogClose()
        {
            _logWriter.Close();
        }

        public static void LogWriteText(string text)
        {
            ABCLogOpen();
            _logWriter.WriteLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + ": " + text);
            ABCLogClose();
        }

        public static void LogWriteFbException(FbException e)
        {
            ABCLogOpen();
            _logWriter.WriteLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + ": FireBird Exception Code: " + e.ErrorCode + "  Error Message: " + e.Message + "  Error Source: " + e.Source);
            ABCLogClose();
        }
    }
}
