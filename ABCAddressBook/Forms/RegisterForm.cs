using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABCAddressBook
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void CCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (KeyText.Text == ABCUtilities.Encode(NameText.Text) && KeyText.Text.Length != 0)
            {
                ABCUtilities.SetRegistrationName(NameText.Text);
                ABCUtilities.SetRegistrationKey(KeyText.Text);
                ABCUtilities.Registered = true;
                MessageBox.Show("Thank you for registering this product.", "ABC Address Book");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("The key you entered is invalid.", "ABC Address Book");
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
        }
    }
}