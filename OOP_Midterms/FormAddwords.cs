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
    public partial class FormAddwords : Form
    {
        
        public string PlayerName { get; private set; }
        public List<string> CustomWords { get; private set; } = new List<string>();
        private Random random;
        private string wordsFilePath = Path.Combine(Directory.GetCurrentDirectory(), "customWords.txt");


        public FormAddwords(string playerName)
        {
            InitializeComponent();
            PlayerName = playerName; // Store the player name
            random = new Random();
            CustomWords = new List<string>(); // Initialize custom words list
            LoadWords(); // Load existing words on form load
        }
        private void FormAddwords_Load(object sender, EventArgs e)
        {

        }
        private void LoadWords()
        {
            if (File.Exists(wordsFilePath))
            {
                string[] words = File.ReadAllLines(wordsFilePath);
                CustomWords.AddRange(words);
                UpdateWordListDisplay();
            }
        }

        private void UpdateWordListDisplay()
        {
            lstWords.Items.Clear(); // Assuming lstWords is the ListBox for displaying words
            foreach (string word in CustomWords)
            {
                lstWords.Items.Add(word); // Add each word to the ListBox
            }
        }
        private void btnAddWord_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void SaveWords()
        {
            File.WriteAllLines(wordsFilePath, CustomWords);
        }

        private void lstWords_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {    
                string newWord = txtWordInput.Text.Trim().ToLower();     
                CustomWords.Add(newWord);
                lstWords.Items.Add(newWord); // Add word to list box for display
                SaveWords(); // Save the updated list to file
                txtWordInput.Clear();

            if (CustomWords.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid word.");
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if (lstWords.SelectedItem != null)
            {
                string selectedWord = lstWords.SelectedItem.ToString();
                CustomWords.Remove(selectedWord);
                UpdateWordListDisplay();
                SaveWords(); // Save the updated list to file
                txtDeletewords.Clear();
            }
            else
            {
                MessageBox.Show("Please select a word to delete.");
            }
        }

        private void lstWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstWords.SelectedItem != null)
            {
                // Get the selected word and display it in the TextBox
                txtDeletewords.Text = lstWords.SelectedItem.ToString(); // Assuming txtDeleteWord is the TextBox for displaying selected word
            }
        }
    }
}

