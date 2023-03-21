namespace OpPassword
{
    partial class SetControlTextForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetControlTextForm));
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxControlText = new System.Windows.Forms.TextBox();
            this.noButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Size = new System.Drawing.Size(331, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter control text";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxControlText
            // 
            this.textBoxControlText.BackColor = System.Drawing.Color.Black;
            this.textBoxControlText.Enabled = false;
            this.textBoxControlText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxControlText.ForeColor = System.Drawing.Color.White;
            this.textBoxControlText.Location = new System.Drawing.Point(46, 88);
            this.textBoxControlText.MaxLength = 14;
            this.textBoxControlText.Name = "textBoxControlText";
            this.textBoxControlText.ReadOnly = true;
            this.textBoxControlText.Size = new System.Drawing.Size(330, 26);
            this.textBoxControlText.TabIndex = 9;
            this.textBoxControlText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.noButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("noButton.BackgroundImage")));
            this.noButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.noButton.Location = new System.Drawing.Point(225, 133);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 34);
            this.noButton.TabIndex = 12;
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.yesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yesButton.BackgroundImage")));
            this.yesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yesButton.Location = new System.Drawing.Point(120, 133);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(75, 34);
            this.yesButton.TabIndex = 11;
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // SetControlTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(427, 179);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.textBoxControlText);
            this.Controls.Add(this.label2);
            this.Name = "SetControlTextForm";
            this.Text = "SetControlTextForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxControlText;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button yesButton;
    }
}