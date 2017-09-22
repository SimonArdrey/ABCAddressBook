using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABCAddressBook
{
    public partial class LoginForm : Form
    {
        public LoginResult _loginResult = new LoginResult();        

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            _loginResult.SelectedButton = SelectedLoginButton.Exit;
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserNameText.Text == "" || PasswordText.Text == "") { MessageBox.Show("You must enter a username and password."); }
            else
            {
                _loginResult.SelectedButton = SelectedLoginButton.Login;
                _loginResult.UserName = UserNameText.Text;
                _loginResult.Password = PasswordText.Text;
                this.Close();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UserNameText.Text = ABCUtilities.GetRegistryValue("UserName");
            if (UserNameText.Text.Length > 0) { this.ActiveControl = PasswordText; }
        }

        private void DatabaseButton_Click(object sender, EventArgs e)
        {
            _loginResult.SelectedButton = SelectedLoginButton.Properties;
            // Database Propertise button clicked.
            this.Close();
        }

        public LoginResult ShowLogin()
        {
            this.ShowDialog();
            return _loginResult;
        }

        public static LoginResult DoLogin()
        {
            LoginForm i = new LoginForm();
            return i.ShowLogin();
        }
    }
}