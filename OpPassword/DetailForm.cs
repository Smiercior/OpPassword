using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpPassword
{
    public partial class DetailForm : Form
    {
        PasswordObject selectedPasswordObject;

        private string password { get; set; }

        public DetailForm(PasswordObject selectedPasswordObject, string password)
        {
            InitializeComponent();
            this.password = password;
            this.selectedPasswordObject = selectedPasswordObject;
            UpdateComponents(false);
            ChangeLock(true);
        }

        // Update text boxes with password object data, decrypt - true ( show decrypted data ), decrypt - false ( show encrypted data )
        private void UpdateComponents(bool decrypt)
        {
            textBoxName.Text = selectedPasswordObject.Name;
            textBoxLink.Text = selectedPasswordObject.Link;

            if(!decrypt)
            {
                textBoxUsername.Text = selectedPasswordObject.Username;
                textBoxEmail.Text = selectedPasswordObject.Email;
                textBoxPassword.Text = selectedPasswordObject.Password;
                textBoxOther.Text = selectedPasswordObject.Other;
            }
            else if(decrypt)
            {
                EncryptDecrypt encryptDecrypt = new EncryptDecrypt(password);
                textBoxUsername.Text = encryptDecrypt.Decrypt(selectedPasswordObject.Username);
                textBoxEmail.Text = encryptDecrypt.Decrypt(selectedPasswordObject.Email);
                textBoxPassword.Text = encryptDecrypt.Decrypt(selectedPasswordObject.Password);
                textBoxOther.Text = encryptDecrypt.Decrypt(selectedPasswordObject.Other);
            }   
        }

        // Change to lock button or to unlock button, false - lock, true - unlock
        private void ChangeLock(bool state)
        {
            lockButton.Enabled = !state;
            lockButton.Visible = !state;
            unlockButton.Enabled = state;
            unlockButton.Visible = state;
        }

        // On no button click
        private void noButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        // On yes button click, update text boxes
        private void editButton_Click(object sender, EventArgs e)
        {
            using (var editForm = new EditForm(selectedPasswordObject, password))
            {
                editForm.StartPosition = FormStartPosition.CenterParent;
                var result = editForm.ShowDialog(this);

                if (result == DialogResult.Yes)
                {
                    UpdateComponents(false);
                }
            }
        }

        // On unlock button click, show decrypted data
        private void unlockButton_Click(object sender, EventArgs e)
        {
            ChangeLock(false);
            UpdateComponents(true);
        }

        // On lock button click, show encrypted data
        private void lockButton_Click(object sender, EventArgs e)
        {
            ChangeLock(true);
            UpdateComponents(false);
        }

        // On text box click, open new tab in browser
        private void textBoxLink_Click(object sender, EventArgs e)
        {
            Process.Start(textBoxLink.Text);
        }
    }
}
