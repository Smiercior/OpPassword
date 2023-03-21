namespace OpPassword
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.passwordList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.passwordList2 = new System.Windows.Forms.ListBox();
            this.passwordList3 = new System.Windows.Forms.ListBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Black;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.ForeColor = System.Drawing.Color.White;
            this.textBoxName.Location = new System.Drawing.Point(43, 39);
            this.textBoxName.MaxLength = 14;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(242, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(330, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(178, 26);
            this.textBox1.TabIndex = 3;
            // 
            // passwordList
            // 
            this.passwordList.BackColor = System.Drawing.Color.Black;
            this.passwordList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordList.ColumnWidth = 20;
            this.passwordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordList.ForeColor = System.Drawing.Color.White;
            this.passwordList.FormattingEnabled = true;
            this.passwordList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.passwordList.ItemHeight = 20;
            this.passwordList.Location = new System.Drawing.Point(43, 126);
            this.passwordList.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.passwordList.Name = "passwordList";
            this.passwordList.Size = new System.Drawing.Size(159, 240);
            this.passwordList.TabIndex = 4;
            this.passwordList.TabStop = false;
            this.passwordList.UseTabStops = false;
            this.passwordList.SelectedIndexChanged += new System.EventHandler(this.passwordList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Size = new System.Drawing.Size(465, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name                          Create date                  Modify date";
            // 
            // passwordList2
            // 
            this.passwordList2.BackColor = System.Drawing.Color.Black;
            this.passwordList2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordList2.ColumnWidth = 20;
            this.passwordList2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordList2.ForeColor = System.Drawing.Color.White;
            this.passwordList2.FormattingEnabled = true;
            this.passwordList2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.passwordList2.ItemHeight = 20;
            this.passwordList2.Location = new System.Drawing.Point(192, 126);
            this.passwordList2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.passwordList2.Name = "passwordList2";
            this.passwordList2.Size = new System.Drawing.Size(159, 240);
            this.passwordList2.TabIndex = 10;
            this.passwordList2.TabStop = false;
            this.passwordList2.UseTabStops = false;
            this.passwordList2.SelectedIndexChanged += new System.EventHandler(this.passwordList2_SelectedIndexChanged);
            // 
            // passwordList3
            // 
            this.passwordList3.BackColor = System.Drawing.Color.Black;
            this.passwordList3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordList3.ColumnWidth = 20;
            this.passwordList3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordList3.ForeColor = System.Drawing.Color.White;
            this.passwordList3.FormattingEnabled = true;
            this.passwordList3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.passwordList3.ItemHeight = 20;
            this.passwordList3.Location = new System.Drawing.Point(349, 126);
            this.passwordList3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.passwordList3.Name = "passwordList3";
            this.passwordList3.Size = new System.Drawing.Size(159, 240);
            this.passwordList3.TabIndex = 11;
            this.passwordList3.TabStop = false;
            this.passwordList3.UseTabStops = false;
            this.passwordList3.SelectedIndexChanged += new System.EventHandler(this.passwordList3_SelectedIndexChanged);
            // 
            // displayButton
            // 
            this.displayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.displayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("displayButton.BackgroundImage")));
            this.displayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.displayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.displayButton.Location = new System.Drawing.Point(330, 387);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 34);
            this.displayButton.TabIndex = 9;
            this.displayButton.UseVisualStyleBackColor = false;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.removeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeButton.BackgroundImage")));
            this.removeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeButton.Location = new System.Drawing.Point(232, 387);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 34);
            this.removeButton.TabIndex = 8;
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.addButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton.BackgroundImage")));
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Location = new System.Drawing.Point(127, 387);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 34);
            this.addButton.TabIndex = 7;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.Location = new System.Drawing.Point(291, 39);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(33, 26);
            this.searchButton.TabIndex = 2;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.passwordList3);
            this.Controls.Add(this.passwordList2);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBoxName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OpPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox passwordList;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.ListBox passwordList2;
        private System.Windows.Forms.ListBox passwordList3;
    }
}

