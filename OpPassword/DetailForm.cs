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
    public partial class DetailForm : Form
    {
        PasswordObject selectedPasswordObject;
        private string password { get; set; }

        public DetailForm(PasswordObject selectedPasswordObject, string password)
        {
            InitializeComponent();
            this.password = password;
            this.selectedPasswordObject = selectedPasswordObject;
            UpdateComponents();
        }

        // Update text boxes with password object data
        private void UpdateComponents()
        {
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

        // On yes button click, update text boxes
        private void editButton_Click(object sender, EventArgs e)
        {
            using (var editForm = new EditForm(selectedPasswordObject))
            {
                editForm.StartPosition = FormStartPosition.CenterParent;
                var result = editForm.ShowDialog(this);

                if (result == DialogResult.Yes)
                {
                    UpdateComponents();
                }
            }
        }
    }
}
