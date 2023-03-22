using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace OpPassword
{
    public partial class Form1 : Form
    {
        // Zmienne
        string fileName = "passwords.json";
        string fileName2 = "controlText.txt";
        List<PasswordObject> passwordObjects;
        List<PasswordObject> filteredPasswordObjects;

        public Form1()
        {
            // Initialized lists
            passwordObjects = new List<PasswordObject>();
            filteredPasswordObjects = new List<PasswordObject>();

            // Check if passwords file exists
            if (!File.Exists(fileName)) File.Create(fileName);

            // Check if control text file exists
            if (!File.Exists(fileName2)) File.Create(fileName2);

            // Initialize form components
            InitializeComponent();

            // Read all passwords
            ReadJsonData();

            // Read password to password list
            ReadPasswordToList(passwordObjects);        
        }

        // Save list of PasswordObject to file
        void SaveJsonData()
        {
            string jsonString = JsonSerializer.Serialize<List<PasswordObject>>(passwordObjects);
            File.WriteAllText(fileName, jsonString);
        }

        // Read list of PasswordObject from file
        void ReadJsonData()
        {  
            string jsonString = File.ReadAllText(fileName);
            try
            {
                passwordObjects = JsonSerializer.Deserialize<List<PasswordObject>>(jsonString);
            }
            catch (JsonException)
            {
            }     
        }

        // Read passwords to list
        void ReadPasswordToList(List<PasswordObject> passwordObjects)
        {
            foreach (PasswordObject passwordObject in passwordObjects)
            {
                passwordList.Items.Add(passwordObject.Name);
                passwordList2.Items.Add(passwordObject.CreateDate.Date.ToString("yyyy/MM/dd"));
                passwordList3.Items.Add(passwordObject.ModifyDate.Date.ToString("yyyy/MM/dd"));
            }
        }

        // Clear passwords from password list
        void ClearList()
        {
            passwordList.Items.Clear();
            passwordList2.Items.Clear();
            passwordList3.Items.Clear();
        }

        // Check if password is correct
        private bool ValidatePassword()
        {
            if(textBoxPassword.Text.Length == 0)
            {
                labelWarning.Text = "You must enter the password";
                return false;
            }
            else if(textBoxPassword.Text.Length < 10)
            {
                labelWarning.Text = "Password length should be at least 10 characters";
                return false;
            }
            else if(textBoxPassword.Text != textBoxPasswordConfirm.Text)
            {
                labelWarning.Text = "Both passwords must be the same";
                return false;
            }

            return true;
        }


        // Filter password list by password name
        private void searchButton_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            ClearList();

            if (name != "")
            {
                filteredPasswordObjects = passwordObjects.FindAll((passwordObject) => passwordObject.Name.ToLower().Contains(textBoxName.Text.ToLower()));
                ReadPasswordToList(filteredPasswordObjects);
            }
            else
            {
                ReadPasswordToList(passwordObjects);
            }   
        }

        // Remove selected password from password list
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (passwordList.SelectedItem != null)
            {
                string name = passwordList.SelectedItem.ToString();

                using(var delForm = new DelForm(name))
                {
                    delForm.StartPosition = FormStartPosition.CenterParent;
                    var result = delForm.ShowDialog(this);

                    if(result == DialogResult.Yes)
                    {
                        passwordObjects.Remove(passwordObjects.Find((passwordObject) => passwordObject.Name == name));
                        ClearList();
                        ReadPasswordToList(passwordObjects);
                    }
                }
            }
        }

        // Add new password
        private void addButton_Click(object sender, EventArgs e)
        {
            if(ValidatePassword())
            {
                using (var newForm = new NewForm(textBoxPassword.Text))
                {
                    newForm.StartPosition = FormStartPosition.CenterParent;
                    var result = newForm.ShowDialog(this);

                    if (result == DialogResult.Yes)
                    {
                        PasswordObject newPasswordObject = newForm.newPasswordObject;
                        passwordObjects.Add(newPasswordObject);

                        ClearList();
                        ReadPasswordToList(passwordObjects);
                        SaveJsonData();
                    }
                }
            }    
        }

        // Show password object data in nwe form
        private void displayButton_Click(object sender, EventArgs e)
        {
            if(ValidatePassword())
            {
                if (passwordList.SelectedItem != null)
                {
                    PasswordObject selectedPasswordObject = passwordObjects.Find((passwordObject) => passwordObject.Name == passwordList.SelectedItem.ToString());
                    if (selectedPasswordObject != null)
                    {
                        using (var detailForm = new DetailForm(selectedPasswordObject, textBoxPassword.Text))
                        {
                            detailForm.StartPosition = FormStartPosition.CenterParent;
                            var result = detailForm.ShowDialog(this);
                            SaveJsonData();
                        }
                    }
                }
            }         
        }

        private void passwordList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = passwordList.SelectedIndex;
            passwordList2.SelectedIndex = index;
            passwordList3.SelectedIndex = index;
        }

        private void passwordList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = passwordList2.SelectedIndex;
            passwordList.SelectedIndex = index;
            passwordList3.SelectedIndex = index;
        }

        private void passwordList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = passwordList3.SelectedIndex;
            passwordList.SelectedIndex = index;
            passwordList2.SelectedIndex = index;
        }

        // On set control text button click, open a new form, where the user can type control text
        // This control text is used to identify if the password is correct ( after decrypting, it should make sense to the user )
        private void setControlTextButton_Click(object sender, EventArgs e)
        {
            if (ValidatePassword())
            {
                using (var setControlTextForm = new SetControlTextForm())
                {
                    setControlTextForm.StartPosition = FormStartPosition.CenterParent;
                    var result = setControlTextForm.ShowDialog(this);
                    if (result == DialogResult.Yes)
                    {
                        string controlText = setControlTextForm.controlText;
                        string encryptedControlText = "";

                        EncyprtDecrypt encryptDecrypt = new EncyprtDecrypt(textBoxPassword.Text);
                        encryptedControlText = encryptDecrypt.Encrypt(controlText);
                        File.WriteAllText(fileName2, encryptedControlText);
                    }
                }
            }
        }

        // On show control text button click
        private void showControlTextButton_Click(object sender, EventArgs e)
        { 
            if(ValidatePassword())
            {
                string encryptedControlText = "";
                string controlText = "";

                EncyprtDecrypt encryptDecrypt = new EncyprtDecrypt(textBoxPassword.Text);
                encryptedControlText = File.ReadAllText(fileName2);
                controlText = encryptDecrypt.Decrypt(encryptedControlText);
            
                using (var showControlTextForm = new ShowControlTextForm(controlText))
                {
                    showControlTextForm.StartPosition = FormStartPosition.CenterParent;
                    var result = showControlTextForm.ShowDialog(this);
                }
            }          
        }
    }
}
