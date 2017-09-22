using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABCAddressBook
{
    public partial class ListEditForm : Form
    {
        public ListEditResult Result = new ListEditResult();        

        public ListEditForm()
        {
            InitializeComponent();
        }

        public ListEditResult ShowListEditBox(string question, string title, string[] list)
        {            
            QuestionLabel.Text = question;
            this.Text = title;
            ItemsList.Items.AddRange(list);
            if (ItemsList.Items.Count > 0) { ItemsList.SelectedIndex = 0; }
            this.ShowDialog();
            return this.Result;
        }

        public static ListEditResult ListEditBox(string question, string title, string[] list)
        {
            ListEditForm i = new ListEditForm();
            return i.ShowListEditBox(question, title, list);
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            if (ItemsList.SelectedIndex != -1)
            {
                int index = ItemsList.SelectedIndex;
                if (index != 0)
                {
                    string item = (string)ItemsList.SelectedItem;
                    ItemsList.Items.Remove(item);
                    ItemsList.Items.Insert(index - 1, item);
                    ItemsList.SelectedIndex = index - 1;
                }
            }
            else { MessageBox.Show("Please select or add and item first.", this.Text); }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            InputBoxResult r = InputBoxForm.InputBox("Please enter an item.", this.Text);
            if (r.OK && r.InputText.Length > 0) { ItemsList.Items.Add(r.InputText); }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ItemsList.SelectedIndex != -1)
            {
                ItemsList.Items.RemoveAt(ItemsList.SelectedIndex);
                if (ItemsList.Items.Count > 0) { ItemsList.SelectedIndex = 0; }
            }
            else { MessageBox.Show("Please select or add and item first.", this.Text); }
            
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            if (ItemsList.SelectedIndex != -1)
            {
                int index = ItemsList.SelectedIndex;
                if (index != ItemsList.Items.Count - 1)
                {
                    string item = (string)ItemsList.SelectedItem;
                    ItemsList.Items.Remove(item);
                    ItemsList.Items.Insert(index + 1, item);
                    ItemsList.SelectedIndex = index + 1;
                }
            }
            else { MessageBox.Show("Please select or add and item first.", this.Text); }
        }

        private void CCancelButton_Click(object sender, EventArgs e)
        {
            string[] list = new string[ItemsList.Items.Count];
            ItemsList.Items.CopyTo(list, 0);
            Result.OK = false;
            Result.list = list;
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string[] list = new string[ItemsList.Items.Count];
            ItemsList.Items.CopyTo(list, 0);
            Result.OK = true;
            Result.list = list;
            this.Close();
        }

        private void ItemsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListEditForm_Load(object sender, EventArgs e)
        {

        }
    }    
}