using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using System.Security.Permissions;
using System.Windows.Forms;
using ABCAddressBook;

namespace ABCRemoteClient
{
    public static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {         
            ABCRemoteObject remObject = (ABCRemoteObject)Activator.GetObject(typeof(ABCRemoteObject), "ipc://ABCAddressBook/ABCRemoteServer");            
            if (remObject == null) { MessageBox.Show("Please start ABC Address Book before using this utility."); }
            else 
            { 
                try
                { remObject.Commands(args); }
                catch
                { MessageBox.Show("Please start ABC Address Book before using this utility."); }
            }
        }
    }
}
