using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABCAddressBook
{
    static class Program
    {
  
        [STAThread]
        static void Main()
        {    
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if (ABCUtilities.Connect())
            {                
                Application.Run(new MainForm());
            }
        }
    }
}