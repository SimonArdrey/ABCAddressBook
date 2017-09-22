namespace ABCAddressBook
{
    partial class ReportViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReportView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReportView
            // 
            this.ReportView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportView.LocalReport.ReportEmbeddedResource = "ABCAddressBook.ContactDetailsReport.rdlc";
            this.ReportView.Location = new System.Drawing.Point(0, 0);
            this.ReportView.Name = "ReportView";
            this.ReportView.ShowBackButton = false;
            this.ReportView.ShowContextMenu = false;
            this.ReportView.ShowCredentialPrompts = false;
            this.ReportView.ShowFindControls = false;
            this.ReportView.ShowParameterPrompts = false;
            this.ReportView.ShowPromptAreaButton = false;
            this.ReportView.ShowRefreshButton = false;
            this.ReportView.ShowStopButton = false;
            this.ReportView.Size = new System.Drawing.Size(609, 519);
            this.ReportView.TabIndex = 0;
            // 
            // ReportViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 519);
            this.Controls.Add(this.ReportView);
            this.Name = "ReportViewForm";
            this.Text = "View Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportViewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportView;
    }
}