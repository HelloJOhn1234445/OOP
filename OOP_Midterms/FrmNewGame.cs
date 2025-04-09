using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP_Midterms
{
    public partial class FrmNewGame : Form
    {
        string direct = Path.Combine(Directory.GetCurrentDirectory(), "TBoard.txt");


        public FrmNewGame()
        {
            InitializeComponent();

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {


        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void FrmNewGame_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string playerName = txtUsername.Text.Trim(); // Capture the username
            if (!string.IsNullOrEmpty(playerName))
            {
                FrmGame wordEntryForm = new FrmGame(playerName); // Pass the username to the FrmGame constructor
                wordEntryForm.Show();
                this.Hide(); // Optionally hide the current form
            }
            else
            {
                MessageBox.Show("Please enter your username.");
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
