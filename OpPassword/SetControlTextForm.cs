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
    public partial class SetControlTextForm : Form
    {
        public string controlText { get; set; }
        public SetControlTextForm()
        {
            InitializeComponent();
        }

        // On no button click
        private void noButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        // On yes button click, get control text from text box
        private void yesButton_Click(object sender, EventArgs e)
        {
            controlText = textBoxControlText.Text;
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
