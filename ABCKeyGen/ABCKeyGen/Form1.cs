using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABCKeyGen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public string Encode(string name)
        {
            name = name.PadRight(16, ' ');
            Random random = new Random();
            string text = "";

            for (int i = 0; i < name.Length; i++)
            {
                if (i == 0) { text += ToBase36(name[i] ^ 20); }
                else { text += ToBase36(name[i] ^ name[i - 1]); }
            }

            return text.Remove(0, text.Length - 16);
        }

        public string ToBase36(int num)
        {
            string base36num = "";
            int remainder;
            int division;

            do
            {
                remainder = num % 36;
                division = num / 36;
                base36num = ToBase36Char(remainder).ToString() + base36num;
                num = division;
            } while (division != 0);

            return base36num;
        }

        public char ToBase36Char(int num)
        {
            string alpha = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return alpha[num];
        }

        public int Base36CharToDec(char numeral)
        {
            int num = Convert.ToInt16(numeral);
            if (num >= 48 && num <= 57) { return num - 48; }
            if (num >= 65 && num <= 90) { return num - 55; }
            return 0;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            KeyText.Text = Encode(NameText.Text);
        }

    }
}