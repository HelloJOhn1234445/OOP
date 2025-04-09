using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Midterms
{
    public partial class InputBoxForm : Form
    {
        public string UserInput { get; private set; } = string.Empty;
        public InputBoxForm(string prompt)
        {
            InitializeComponent();
            lblPrompt.Text = prompt;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            UserInput = txtInput.Text.Trim();
            this.DialogResult = DialogResult.OK; // Indicate OK was clicked
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Indicate Cancel was clicked
            this.Close();
        }

        private void lblPrompt_Click(object sender, EventArgs e)
        {

        }

        private void InputBoxForm_Load(object sender, EventArgs e)
        {

        }
    }
}
