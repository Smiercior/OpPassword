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

        private string password { get; set; }
        public EditForm(PasswordObject selectedPasswordObject, string password)
        {
            InitializeComponent();
            this.selectedPasswordObject = selectedPasswordObject;
            this.password = password;
            UpdateComponents();
        }

        // Update text boxes with password object data
        private void UpdateComponents()
        {
            textBoxName.Text = selectedPasswordObject.Name;
            textBoxLink.Text = selectedPasswordObject.Link;

            EncryptDecrypt encryptDecrypt = new EncryptDecrypt(password);
            textBoxUsername.Text = encryptDecrypt.Decrypt(selectedPasswordObject.Username);
            textBoxEmail.Text = encryptDecrypt.Decrypt(selectedPasswordObject.Email);
            textBoxPassword.Text = encryptDecrypt.Decrypt(selectedPasswordObject.Password);
            textBoxOther.Text = encryptDecrypt.Decrypt(selectedPasswordObject.Other);
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
            selectedPasswordObject.Link = textBoxLink.Text;

            EncryptDecrypt encryptDecrypt = new EncryptDecrypt(password);
            selectedPasswordObject.Username = encryptDecrypt.Encrypt(textBoxUsername.Text);
            selectedPasswordObject.Email = encryptDecrypt.Encrypt(textBoxEmail.Text);
            selectedPasswordObject.Password = encryptDecrypt.Encrypt(textBoxPassword.Text);
            selectedPasswordObject.Other = encryptDecrypt.Encrypt(textBoxOther.Text);

            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
