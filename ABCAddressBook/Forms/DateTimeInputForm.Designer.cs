namespace ABCAddressBook
{
    partial class DateTimeInputForm
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
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateTimePicker.Location = new System.Drawing.Point(8, 24);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.ShowUpDown = true;
            this.DateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.DateTimePicker.TabIndex = 0;
            this.DateTimePicker.Value = new System.DateTime(2008, 3, 6, 21, 13, 0, 0);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(5, 8);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(84, 13);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "Question Label?";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(104, 56);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(88, 24);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "&OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CCancelButton
            // 
            this.CCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CCancelButton.Location = new System.Drawing.Point(8, 56);
            this.CCancelButton.Name = "CCancelButton";
            this.CCancelButton.Size = new System.Drawing.Size(88, 24);
            this.CCancelButton.TabIndex = 3;
            this.CCancelButton.Text = "Cancel";
            this.CCancelButton.UseVisualStyleBackColor = true;
            this.CCancelButton.Click += new System.EventHandler(this.CCancelButton_Click);
            // 
            // DateTimeInputForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CCancelButton;
            this.ClientSize = new System.Drawing.Size(204, 88);
            this.Controls.Add(this.CCancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.DateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DateTimeInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input";
            this.Load += new System.EventHandler(this.DateTimeInputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CCancelButton;
    }
}