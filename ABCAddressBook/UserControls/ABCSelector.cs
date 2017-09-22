using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ABCAddressBook
{    
    public partial class ABCSelector : UserControl
    {
        public delegate void ABCSelectorClick(object sender, ABCSelectorEventArgs e);

        [Category("Action")]
        [Description("Fire when users clicks a letter.")]
        public event ABCSelectorClick SelectorClickHandler;

        private System.Windows.Forms.Button[] _selectorButtons;

        public ABCSelector()
        {            
            this._selectorButtons = new System.Windows.Forms.Button[26];
            for (int i = 0; i <= 25; i++)
            {                
                this._selectorButtons[i] = new System.Windows.Forms.Button();                
                this._selectorButtons[i].BackColor = System.Drawing.Color.Gray;                
                this._selectorButtons[i].FlatAppearance.BorderSize = 0;
                this._selectorButtons[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this._selectorButtons[i].Font = new System.Drawing.Font("Arail", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this._selectorButtons[i].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                this._selectorButtons[i].Location = GetLocation(i);                
                this._selectorButtons[i].Name = "SelectorButton";
                this._selectorButtons[i].Size = GetSize(i);
                this._selectorButtons[i].TabIndex = i;
                this._selectorButtons[i].Tag = i; // Index integer object.
                char sText = Convert.ToChar(65 + i);
                this._selectorButtons[i].Text = sText.ToString();
                this._selectorButtons[i].UseVisualStyleBackColor = false;
                this._selectorButtons[i].Click += new System.EventHandler(this.ButtonClick);
                this.Controls.Add(this._selectorButtons[i]);                                
            }

            InitializeComponent();
        }

        private System.Drawing.Point GetLocation(int buttonNumber) 
        {
            int top = this.Size.Height / this._selectorButtons.Length * buttonNumber;
            return new System.Drawing.Point(0, top);
        }

        private System.Drawing.Size GetSize(int buttonNumber)
        { return new System.Drawing.Size(this.Size.Width, this.Size.Height / this._selectorButtons.Length); }

        private void ButtonClick(object sender, System.EventArgs e) 
        {
            if (SelectorClickHandler != null)
            {
                System.Windows.Forms.Button i = (System.Windows.Forms.Button)sender;
                SelectorClickHandler(this, new ABCSelectorEventArgs(i.Text));
            }
        }

        private void ABCSelector_Resize(object sender, EventArgs e)
        {
            for (int i = 0; i <= 25; i++)
            {
                this._selectorButtons[i].Size = GetSize(i);
                this._selectorButtons[i].Location = GetLocation(i);
            }
        }
    }
}
