using System;
using System.Collections.Generic;
using System.Text;

namespace ABCAddressBook
{
    public sealed class MessageUser
    {
        public String UserName;
        public String ScreenName;

        public MessageUser() { }
        
        public MessageUser(String UserName, String ScreenName)
        {
            this.UserName = UserName;
            this.ScreenName = ScreenName;
        }

        public override String ToString()
        { return ScreenName; }
    }
}
