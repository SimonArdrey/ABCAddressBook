using System;
using System.Collections.Generic;
using System.Text;

namespace ABCAddressBook
{
    public sealed class InputBoxResult
    {
        public string InputText = "";
        public Boolean OK = false;        

        public InputBoxResult() {}

        public InputBoxResult(string inputText, Boolean okButton)
        {
            InputText = inputText;
            OK = okButton;            
        }
    }
}
