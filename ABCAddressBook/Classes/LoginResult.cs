using System;
using System.Collections.Generic;
using System.Text;

namespace ABCAddressBook
{
    public enum SelectedLoginButton
    {
        Login = 1,
        Exit = 2,
        Properties = 3
    };

    public sealed class LoginResult
    {
        public string UserName;
        public string Password;
        public SelectedLoginButton SelectedButton;
    }
}
