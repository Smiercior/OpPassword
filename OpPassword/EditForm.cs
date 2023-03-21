using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpPassword
{
    public partial class EditForm : Form
    {
        PasswordObject selectedPasswordObject;
        public EditForm(PasswordObject selectedPasswordObject)
        {
            InitializeComponent();
            this.selectedPasswordObject = selectedPasswordObject;
            textBoxName.Text = selectedPasswordObject.Name;
            textBoxUsername.Text = selectedPasswordObject.Username;
            textBoxEmail.Text = selectedPasswordObject.Email;
            textBoxPassword.Text = selectedPasswordObject.Password;
            textBoxLink.Text = selectedPasswordObject.Link;
            textBoxOther.Text = selectedPasswordObject.Other;
        }

        // On no button click
        private void noButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        // On yes button click, update password object data
        private void yesButton_Click(object sender, EventArgs e)
        {
            selectedPasswordObject.Name = textBoxName.Text;
            selectedPasswordObject.Username = textBoxUsername.Text;
            selectedPasswordObject.Email = textBoxEmail.Text;
            selectedPasswordObject.Password = textBoxPassword.Text;
            selectedPasswordObject.Link = textBoxLink.Text;
            selectedPasswordObject.Other = textBoxOther.Text;
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
