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
        List<PasswordObject> passwordObjects;
        List<PasswordObject> filteredPasswordObjects;

        public Form1()
        {
            // Initialized lists
            passwordObjects = new List<PasswordObject>();
            filteredPasswordObjects = new List<PasswordObject>();

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
            passwordObjects = JsonSerializer.Deserialize<List<PasswordObject>>(jsonString);
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
            using(var newForm = new NewForm())
            {
                newForm.StartPosition = FormStartPosition.CenterParent;
                var result = newForm.ShowDialog(this);
                
                if(result == DialogResult.Yes)
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
}
