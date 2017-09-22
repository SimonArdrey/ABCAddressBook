namespace ABCAddressBook
{
    partial class DatabasePropertiesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DatabaseText = new System.Windows.Forms.TextBox();
            this.ServerText = new System.Windows.Forms.TextBox();
            this.ConnectionTypeCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AutoLoginCheck = new System.Windows.Forms.CheckBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.DBCancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DatabaseText);
            this.groupBox1.Controls.Add(this.ServerText);
            this.groupBox1.Controls.Add(this.ConnectionTypeCombo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Connection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Database Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Server Address:";
            // 
            // DatabaseText
            // 
            this.DatabaseText.Location = new System.Drawing.Point(104, 72);
            this.DatabaseText.Name = "DatabaseText";
            this.DatabaseText.Size = new System.Drawing.Size(176, 20);
            this.DatabaseText.TabIndex = 3;
            // 
            // ServerText
            // 
            this.ServerText.Location = new System.Drawing.Point(104, 48);
            this.ServerText.Name = "ServerText";
            this.ServerText.Size = new System.Drawing.Size(176, 20);
            this.ServerText.TabIndex = 2;
            // 
            // ConnectionTypeCombo
            // 
            this.ConnectionTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConnectionTypeCombo.FormattingEnabled = true;
            this.ConnectionTypeCombo.Items.AddRange(new object[] {
            "Server",
            "Local File"});
            this.ConnectionTypeCombo.Location = new System.Drawing.Point(104, 24);
            this.ConnectionTypeCombo.Name = "ConnectionTypeCombo";
            this.ConnectionTypeCombo.Size = new System.Drawing.Size(176, 21);
            this.ConnectionTypeCombo.TabIndex = 1;
            this.ConnectionTypeCombo.SelectedIndexChanged += new System.EventHandler(this.ConnectionTypeCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "User Name:";
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(104, 64);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(176, 20);
            this.PasswordText.TabIndex = 5;
            // 
            // UserNameText
            // 
            this.UserNameText.Location = new System.Drawing.Point(104, 40);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(176, 20);
            this.UserNameText.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AutoLoginCheck);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.UserNameText);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PasswordText);
            this.groupBox2.Location = new System.Drawing.Point(8, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // AutoLoginCheck
            // 
            this.AutoLoginCheck.AutoSize = true;
            this.AutoLoginCheck.Location = new System.Drawing.Point(104, 16);
            this.AutoLoginCheck.Name = "AutoLoginCheck";
            this.AutoLoginCheck.Size = new System.Drawing.Size(77, 17);
            this.AutoLoginCheck.TabIndex = 10;
            this.AutoLoginCheck.Text = "Auto Login";
            this.AutoLoginCheck.UseVisualStyleBackColor = true;
            this.AutoLoginCheck.CheckedChanged += new System.EventHandler(this.AutoLoginCheck_CheckedChanged);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(208, 224);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(96, 24);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "&OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // DBCancelButton
            // 
            this.DBCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DBCancelButton.Location = new System.Drawing.Point(104, 224);
            this.DBCancelButton.Name = "DBCancelButton";
            this.DBCancelButton.Size = new System.Drawing.Size(96, 24);
            this.DBCancelButton.TabIndex = 3;
            this.DBCancelButton.Text = "&Cancel";
            this.DBCancelButton.UseVisualStyleBackColor = true;
            this.DBCancelButton.Click += new System.EventHandler(this.DBCancelButton_Click);
            // 
            // DatabasePropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DBCancelButton;
            this.ClientSize = new System.Drawing.Size(308, 256);
            this.Controls.Add(this.DBCancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabasePropertiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Properties";
            this.Load += new System.EventHandler(this.DatabaseProperties_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ConnectionTypeCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.TextBox DatabaseText;
        private System.Windows.Forms.TextBox ServerText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox AutoLoginCheck;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button DBCancelButton;
    }
}