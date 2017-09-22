using System;
using System.Collections.Generic;
using System.Text;

namespace ABCAddressBook
{
    class ABCSelectorEventArgs : System.EventArgs
    {
        public readonly string SelectedLetter;

        public ABCSelectorEventArgs(string selectedLetter)
        {
            this.SelectedLetter = selectedLetter;
        }   
    }
}
