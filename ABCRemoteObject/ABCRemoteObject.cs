using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace ABCAddressBook
{    
    public class ABCRemoteObject : MarshalByRefObject
    {
        public delegate void CommandsHandler(string[] args);
        public event CommandsHandler CommandsEvent;

        public void Commands(string[] args)
        {
            if (CommandsEvent != null) { CommandsEvent(args); }
        }

        public override Object InitializeLifetimeService()
        {
            return null;
        }
    }
}
