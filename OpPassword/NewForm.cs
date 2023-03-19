using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OpPassword
{
    public partial class NewForm : Form
    {
        public PasswordObject newPasswordObject;

        public NewForm()
        {
            InitializeComponent();
        }

        bool ValidateTextBoxes()
        {
            if (textBoxName.Text != "" && textBoxUsername.Text != "" && textBoxEmail.Text != "" && textBoxPassword.Text != "")
            {
                Regex validateEmailRegex = new Regex("^\\S+@\\S+\\.\\S+$");
                if(validateEmailRegex.IsMatch(textBoxEmail.Text))
                {
                    return true;
                }
            }
            return false;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {        
            if(ValidateTextBoxes())
            {
                newPasswordObject = new PasswordObject();
                newPasswordObject.Name = textBoxName.Text;
                newPasswordObject.CreateDate = DateTime.Now;
                newPasswordObject.ModifyDate = DateTime.Now;
                newPasswordObject.Username = textBoxUsername.Text;
                newPasswordObject.Email = textBoxEmail.Text;
                newPasswordObject.Password = textBoxPassword.Text;
                newPasswordObject.Other = textBoxOther.Text;

                this.DialogResult = DialogResult.Yes;
                this.Close();     
            }
            else
            {
            }
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
