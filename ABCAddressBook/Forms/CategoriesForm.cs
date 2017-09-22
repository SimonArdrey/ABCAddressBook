using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace ABCAddressBook
{
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            FillCategoriesList();
        }

        private void FillCategoriesList()
        {
            FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
            fbcmd.CommandText = "SELECT CATEGORY_ID, CATEGORY FROM CATEGORIES ORDER BY CATEGORY ASC;";            
            DataTable CategoriesTable = new DataTable();
            FbDataAdapter adapter = new FbDataAdapter(fbcmd);
            adapter.Fill(CategoriesTable);

            CategoriesList.DisplayMember = "CATEGORY";
            CategoriesList.ValueMember = "CATEGORY_ID";
            CategoriesList.DataSource = CategoriesTable;
            CategoriesList.SelectedIndex = 0;            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {            
            DialogResult mresult = MessageBox.Show("Are you sure you want to delete the category '" + CategoriesList.Text + "'?", "Categories", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mresult == DialogResult.No) { return; }

            FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
            fbcmd.CommandType = CommandType.StoredProcedure;
            fbcmd.CommandText = "DELETE_CATEGORY";
            fbcmd.Parameters.Add("@ID", CategoriesList.SelectedValue.ToString());
            FbParameter result = fbcmd.Parameters.Add("@RESULT", FbDbType.SmallInt, 1);
            result.Direction = ParameterDirection.Output;
            fbcmd.ExecuteNonQuery();
            
            if ((short)result.Value == 0) { FillCategoriesList(); }
            else { MessageBox.Show("Unable to remove '" + CategoriesList.Text + "' because there are '" + result + "' contacts currently using it. First change or remove the contacts using this category.", "Categories", MessageBoxButtons.OK, MessageBoxIcon.Error); }                      
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            InputBoxResult result = InputBoxForm.InputBox("Enter Category", "Categories");
            if (result.OK)
            {
                if (result.InputText.Length > 30) { result.InputText = result.InputText.PadRight(30, ' '); }
                FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
                fbcmd.CommandText = "INSERT INTO CATEGORIES (CATEGORY) VALUES ('@CATEGORY@')";
                fbcmd.CommandText = fbcmd.CommandText.Replace("@CATEGORY@", ABCUtilities.EscapeString(result.InputText));
                fbcmd.ExecuteNonQuery();                
                FillCategoriesList();
            }            
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            InputBoxResult result = InputBoxForm.InputBox("Edit Category", "Categories", CategoriesList.Text);
            if (result.OK)
            {
                FbCommand fbcmd = ABCUtilities.DataConnection.CreateCommand();
                fbcmd.CommandText = "UPDATE CATEGORIES SET CATEGORY = '@CATEGORY@' WHERE CATEGORY_ID = @CATEGORY_ID@";
                fbcmd.CommandText = fbcmd.CommandText.Replace("@CATEGORY@", ABCUtilities.EscapeString(result.InputText));
                fbcmd.CommandText = fbcmd.CommandText.Replace("@CATEGORY_ID@", CategoriesList.SelectedValue.ToString());
                fbcmd.ExecuteNonQuery();                
                FillCategoriesList();
            }   
        }
    }
}