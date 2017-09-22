namespace ABCAddressBook
{
    partial class InputBoxForm
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
            this.InputText = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.IBCancelButton = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(8, 24);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(288, 20);
            this.InputText.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(200, 48);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(96, 24);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // IBCancelButton
            // 
            this.IBCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.IBCancelButton.Location = new System.Drawing.Point(96, 48);
            this.IBCancelButton.Name = "IBCancelButton";
            this.IBCancelButton.Size = new System.Drawing.Size(96, 24);
            this.IBCancelButton.TabIndex = 2;
            this.IBCancelButton.Text = "&Cancel";
            this.IBCancelButton.UseVisualStyleBackColor = true;
            this.IBCancelButton.Click += new System.EventHandler(this.IBCancelButton_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(5, 8);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(80, 13);
            this.QuestionLabel.TabIndex = 3;
            this.QuestionLabel.Text = "Question label?";
            // 
            // InputBoxForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.IBCancelButton;
            this.ClientSize = new System.Drawing.Size(302, 79);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.IBCancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.InputText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button IBCancelButton;
        private System.Windows.Forms.Label QuestionLabel;
    }
}