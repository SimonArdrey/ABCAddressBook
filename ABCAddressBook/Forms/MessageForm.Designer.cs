namespace ABCAddressBook
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.DetailsText = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CalledInCheck = new System.Windows.Forms.CheckBox();
            this.PleaseRingCheck = new System.Windows.Forms.CheckBox();
            this.WillRingBackCheck = new System.Windows.Forms.CheckBox();
            this.TelephonedCheck = new System.Windows.Forms.CheckBox();
            this.UrgentCheck = new System.Windows.Forms.CheckBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.SignedLabel = new System.Windows.Forms.Label();
            this.FaxText = new System.Windows.Forms.TextBox();
            this.MobileText = new System.Windows.Forms.TextBox();
            this.TelephoneText = new System.Windows.Forms.TextBox();
            this.FromText = new System.Windows.Forms.TextBox();
            this.SelectUsersButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetailsText
            // 
            this.DetailsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetailsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsText.Location = new System.Drawing.Point(16, 112);
            this.DetailsText.MaxLength = 255;
            this.DetailsText.Multiline = true;
            this.DetailsText.Name = "DetailsText";
            this.DetailsText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DetailsText.Size = new System.Drawing.Size(280, 96);
            this.DetailsText.TabIndex = 3;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(328, 256);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(88, 24);
            this.SendButton.TabIndex = 12;
            this.SendButton.Text = "&Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(424, 256);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(88, 24);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.Text = "&Cancel";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.CalledInCheck);
            this.panel1.Controls.Add(this.PleaseRingCheck);
            this.panel1.Controls.Add(this.WillRingBackCheck);
            this.panel1.Controls.Add(this.TelephonedCheck);
            this.panel1.Controls.Add(this.UrgentCheck);
            this.panel1.Controls.Add(this.TimeLabel);
            this.panel1.Controls.Add(this.DateLabel);
            this.panel1.Controls.Add(this.ToLabel);
            this.panel1.Controls.Add(this.SignedLabel);
            this.panel1.Controls.Add(this.FaxText);
            this.panel1.Controls.Add(this.MobileText);
            this.panel1.Controls.Add(this.TelephoneText);
            this.panel1.Controls.Add(this.FromText);
            this.panel1.Controls.Add(this.DetailsText);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 248);
            this.panel1.TabIndex = 5;
            // 
            // CalledInCheck
            // 
            this.CalledInCheck.AutoSize = true;
            this.CalledInCheck.BackColor = System.Drawing.Color.Transparent;
            this.CalledInCheck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CalledInCheck.FlatAppearance.BorderSize = 2;
            this.CalledInCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.CalledInCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalledInCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalledInCheck.Location = new System.Drawing.Point(424, 208);
            this.CalledInCheck.Name = "CalledInCheck";
            this.CalledInCheck.Size = new System.Drawing.Size(64, 17);
            this.CalledInCheck.TabIndex = 10;
            this.CalledInCheck.Text = "Called In";
            this.CalledInCheck.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CalledInCheck.UseVisualStyleBackColor = false;
            // 
            // PleaseRingCheck
            // 
            this.PleaseRingCheck.AutoSize = true;
            this.PleaseRingCheck.BackColor = System.Drawing.Color.Transparent;
            this.PleaseRingCheck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PleaseRingCheck.FlatAppearance.BorderSize = 2;
            this.PleaseRingCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.PleaseRingCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PleaseRingCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PleaseRingCheck.Location = new System.Drawing.Point(424, 184);
            this.PleaseRingCheck.Name = "PleaseRingCheck";
            this.PleaseRingCheck.Size = new System.Drawing.Size(80, 17);
            this.PleaseRingCheck.TabIndex = 8;
            this.PleaseRingCheck.Text = "Please Ring";
            this.PleaseRingCheck.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PleaseRingCheck.UseVisualStyleBackColor = false;
            // 
            // WillRingBackCheck
            // 
            this.WillRingBackCheck.AutoSize = true;
            this.WillRingBackCheck.BackColor = System.Drawing.Color.Transparent;
            this.WillRingBackCheck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.WillRingBackCheck.FlatAppearance.BorderSize = 2;
            this.WillRingBackCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.WillRingBackCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WillRingBackCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WillRingBackCheck.Location = new System.Drawing.Point(320, 208);
            this.WillRingBackCheck.Name = "WillRingBackCheck";
            this.WillRingBackCheck.Size = new System.Drawing.Size(93, 17);
            this.WillRingBackCheck.TabIndex = 9;
            this.WillRingBackCheck.Text = "Will Ring Back";
            this.WillRingBackCheck.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.WillRingBackCheck.UseVisualStyleBackColor = false;
            // 
            // TelephonedCheck
            // 
            this.TelephonedCheck.AutoSize = true;
            this.TelephonedCheck.BackColor = System.Drawing.Color.Transparent;
            this.TelephonedCheck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.TelephonedCheck.FlatAppearance.BorderSize = 2;
            this.TelephonedCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.TelephonedCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TelephonedCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelephonedCheck.Location = new System.Drawing.Point(320, 184);
            this.TelephonedCheck.Name = "TelephonedCheck";
            this.TelephonedCheck.Size = new System.Drawing.Size(80, 17);
            this.TelephonedCheck.TabIndex = 7;
            this.TelephonedCheck.Text = "Telephoned";
            this.TelephonedCheck.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TelephonedCheck.UseVisualStyleBackColor = false;
            // 
            // UrgentCheck
            // 
            this.UrgentCheck.AutoSize = true;
            this.UrgentCheck.BackColor = System.Drawing.Color.Transparent;
            this.UrgentCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UrgentCheck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UrgentCheck.FlatAppearance.BorderSize = 2;
            this.UrgentCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.UrgentCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UrgentCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrgentCheck.Location = new System.Drawing.Point(216, 216);
            this.UrgentCheck.Name = "UrgentCheck";
            this.UrgentCheck.Size = new System.Drawing.Size(69, 17);
            this.UrgentCheck.TabIndex = 11;
            this.UrgentCheck.Text = "URGENT";
            this.UrgentCheck.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.UrgentCheck.UseVisualStyleBackColor = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(344, 8);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(128, 16);
            this.TimeLabel.TabIndex = 8;
            this.TimeLabel.Text = "HH:MM AM/PM";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateLabel
            // 
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(200, 8);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(112, 16);
            this.DateLabel.TabIndex = 7;
            this.DateLabel.Text = "dd/mm/yyyy";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.BackColor = System.Drawing.Color.Transparent;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.Location = new System.Drawing.Point(32, 32);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(172, 13);
            this.ToLabel.TabIndex = 6;
            this.ToLabel.Text = "<Click \'Select Users\' Button>";
            this.ToLabel.Click += new System.EventHandler(this.SelectUsersButton_Click);
            // 
            // SignedLabel
            // 
            this.SignedLabel.AutoSize = true;
            this.SignedLabel.BackColor = System.Drawing.Color.Transparent;
            this.SignedLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignedLabel.Location = new System.Drawing.Point(72, 218);
            this.SignedLabel.Name = "SignedLabel";
            this.SignedLabel.Size = new System.Drawing.Size(46, 13);
            this.SignedLabel.TabIndex = 5;
            this.SignedLabel.Text = "Signed";
            // 
            // FaxText
            // 
            this.FaxText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FaxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FaxText.Location = new System.Drawing.Point(344, 144);
            this.FaxText.MaxLength = 30;
            this.FaxText.Name = "FaxText";
            this.FaxText.Size = new System.Drawing.Size(152, 13);
            this.FaxText.TabIndex = 6;
            // 
            // MobileText
            // 
            this.MobileText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MobileText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileText.Location = new System.Drawing.Point(344, 120);
            this.MobileText.MaxLength = 30;
            this.MobileText.Name = "MobileText";
            this.MobileText.Size = new System.Drawing.Size(152, 13);
            this.MobileText.TabIndex = 5;
            // 
            // TelephoneText
            // 
            this.TelephoneText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TelephoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelephoneText.Location = new System.Drawing.Point(344, 96);
            this.TelephoneText.MaxLength = 30;
            this.TelephoneText.Name = "TelephoneText";
            this.TelephoneText.Size = new System.Drawing.Size(152, 13);
            this.TelephoneText.TabIndex = 4;
            // 
            // FromText
            // 
            this.FromText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FromText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FromText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromText.Location = new System.Drawing.Point(48, 56);
            this.FromText.MaxLength = 30;
            this.FromText.Name = "FromText";
            this.FromText.Size = new System.Drawing.Size(384, 13);
            this.FromText.TabIndex = 2;
            // 
            // SelectUsersButton
            // 
            this.SelectUsersButton.Location = new System.Drawing.Point(216, 256);
            this.SelectUsersButton.Name = "SelectUsersButton";
            this.SelectUsersButton.Size = new System.Drawing.Size(104, 24);
            this.SelectUsersButton.TabIndex = 1;
            this.SelectUsersButton.Text = "&Select Users";
            this.SelectUsersButton.UseVisualStyleBackColor = true;
            this.SelectUsersButton.Click += new System.EventHandler(this.SelectUsersButton_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 285);
            this.ControlBox = false;
            this.Controls.Add(this.SelectUsersButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SendButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MessageForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox DetailsText;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FromText;
        private System.Windows.Forms.TextBox FaxText;
        private System.Windows.Forms.TextBox MobileText;
        private System.Windows.Forms.TextBox TelephoneText;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label SignedLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.CheckBox UrgentCheck;
        private System.Windows.Forms.CheckBox CalledInCheck;
        private System.Windows.Forms.CheckBox PleaseRingCheck;
        private System.Windows.Forms.CheckBox WillRingBackCheck;
        private System.Windows.Forms.CheckBox TelephonedCheck;
        private System.Windows.Forms.Button SelectUsersButton;
    }
}