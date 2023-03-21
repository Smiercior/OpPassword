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
    public partial class ShowControlTextForm : Form
    {
        public ShowControlTextForm(string controlText)
        {
            InitializeComponent();
            textBoxControlText.Text = controlText;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
