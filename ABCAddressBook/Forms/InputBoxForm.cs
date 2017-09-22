using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABCAddressBook
{
    public partial class InputBoxForm : Form
    {
        private InputBoxResult FormInputBoxResult = new InputBoxResult();

        public InputBoxForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            FormInputBoxResult.InputText = InputText.Text;
            FormInputBoxResult.OK = true;
            this.Close();
        }

        public InputBoxResult ShowInputBox(string question, string title, string defaultText)
        {
            this.Text = title;
            InputText.Text = defaultText;
            QuestionLabel.Text = question;
            this.ShowDialog();
            return FormInputBoxResult;
        }

        public static InputBoxResult InputBox(string question, string title, string defaultText)
        {
            InputBoxForm i = new InputBoxForm();
            return i.ShowInputBox(question, title, defaultText);
        }

        public static InputBoxResult InputBox(string question)
        {
            InputBoxForm i = new InputBoxForm();
            return i.ShowInputBox(question, "Input Box", "");
        }

        public static InputBoxResult InputBox(string question, string title)
        {
            InputBoxForm i = new InputBoxForm();
            return i.ShowInputBox(question, title, "");
        }

        private void IBCancelButton_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
    }
}