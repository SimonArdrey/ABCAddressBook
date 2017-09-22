using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ABCAddressBook
{
    public partial class ReportViewForm : Form
    {
        public ReportViewForm()
        {
            InitializeComponent();
        }

        private void ReportViewForm_Load(object sender, EventArgs e)
        {
            this.ReportView.RefreshReport();
        }

        public static void ViewReport(ReportDataSource rds, String report)
        {
            ReportViewForm i = new ReportViewForm();            
            i.ReportView.LocalReport.ReportEmbeddedResource = report;            
            i.ReportView.LocalReport.DataSources.Add(rds);            
            i.ReportView.LocalReport.Refresh();            
            i.Show();
        }
    }
}