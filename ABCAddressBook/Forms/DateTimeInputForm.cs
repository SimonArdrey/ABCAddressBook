using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABCAddressBook
{
    public partial class DateTimeInputForm : Form
    {
        private DateTimeInputResult FormDateTimeInputResult = new DateTimeInputResult();

        public DateTimeInputForm()
        {
            InitializeComponent();
        }

        private void DateTimeInputForm_Load(object sender, EventArgs e)
        {
            
        }

        public DateTimeInputResult ShowInputBox(string question, string title, DateTime defaultDateTime)
        {
            this.Text = title;
            QuestionLabel.Text = question;
            DateTimePicker.Value = defaultDateTime;
            this.ShowDialog();
            return FormDateTimeInputResult;
        }

        public static DateTimeInputResult InputBox(string question)
        {
            DateTimeInputForm i = new DateTimeInputForm();
            return i.ShowInputBox(question, "Time Input", DateTime.Now);
        }

        public static DateTimeInputResult InputBox(string question, string title)
        {
            DateTimeInputForm i = new DateTimeInputForm();
            return i.ShowInputBox(question, title, DateTime.Now);
        }

        public static DateTimeInputResult InputBox(string question, string title, DateTime defaultDateTime)
        {
            DateTimeInputForm i = new DateTimeInputForm();
            return i.ShowInputBox(question, title, defaultDateTime);
        }

        private void CCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            FormDateTimeInputResult.OK = true;
            FormDateTimeInputResult.SelectedDateTime = DateTimePicker.Value;
            this.Close();
        }
    }
}