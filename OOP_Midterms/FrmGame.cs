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
    public partial class FrmGame : Form
    {
        #region Variables
        private string playerName; // Ensure this is declared at the class level

        Random random;
        List<string> words = new List<string>
                                   {
                                    "array", "exception", "catch", "finally", "variable", "function", "operation", "algorithm", "terminal",
                                    "flowchart", "queue", "linkedlist", "accessibility", "inclusivity", "anomaly", "insertion", "fields",
                                    "programming", "integer", "database", "memory", "stack", "records", "initialization"
                                   };
        int num = 1;
        int score = 0;
        int incorrectGuess;
        string selectedWord;
        char[] displayWord;
        #endregion
        public FrmGame(string playerName)
        {
            InitializeComponent();
            this.playerName = playerName ?? string.Empty; // Ensure playerName is never null
            //this.words = customWords; // Use custom words instead of default
            random = new Random();
            selectedWord = string.Empty; // Initialize with an empty string
            displayWord = new char[0]; // Initialize with an empty char array
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            incorrectGuess = 0;
            random = new Random();
            selectedWord = words[random.Next(words.Count)];
            displayWord = new string('_', selectedWord.Length).ToCharArray();
            string formattedDisplayWord = string.Join(" ", displayWord);
            lblWordDisplay1.Text = formattedDisplayWord;
            lblScore.Text = ("Score: " + score);
            lblNum.Text = (num + "/10");
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {

            string input = txtbox.Text.Trim();// Convert to lowercase for consistent comparison
            bool correctGuess = false;

            if (!string.IsNullOrEmpty(input))
            {
                // If the input is a single character
                if (input.Length == 1)
                {

                    char guess = input[0];

                    for (int i = 0; i < selectedWord.Length; i++)
                    {
                        if (selectedWord[i].ToString().ToLower() == guess.ToString())
                        {
                            displayWord[i] = guess;
                            correctGuess = true;
                        }
                    }

                    lblWordDisplay1.Text = string.Join(" ", displayWord);
                }
                // If the input is the full word guess
                else if (input.Length > 1)
                {
                    if (input == selectedWord)
                    {
                        displayWord = selectedWord.ToCharArray();
                        lblWordDisplay1.Text = string.Join(" ", displayWord);
                        correctGuess = true;
                    }
                }
                // Handle incorrect guess
                if (!correctGuess)
                {
                    UpdateHangmanImage();
                }
                // Check if the player guessed the entire word correctly
                if (!lblWordDisplay1.Text.Contains('_'))
                {
                    score++;
                    num++;
                    lblScore.Text = ("Score: " + score);
                    lblNum.Text = (num + "/10");


                    if (num <= 10)
                    {
                        ResetGameState();
                    }
                    else
                    {
                        SaveScore(playerName, score);
                        MessageBox.Show("Game Over. Thanks for playing!");
                        Form1 Form = new Form1();
                        Form.Show();
                        this.Close();


                    }

                }
            }
            else
            {
                MessageBox.Show("Please enter a valid guess.");
            }
            txtbox.Clear(); // Clear the textbox after each guess


        }
        private void SaveScore(string playerName, int score)
        {
            string direct = Path.Combine(Directory.GetCurrentDirectory(), "TBoard.txt");
            try
            {
                // Save player name and score in format: "PlayerName: Score"
                File.AppendAllText(direct, $"{playerName} : {score}{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving score: {ex.Message}");
            }
        }


        private void ResetGameState()
        {
            // Reset the incorrect guesses counter
            incorrectGuess = 0;

            //Remove previous word to avoid redundancy
            words.Remove(selectedWord);

            // Reset the hangman image
            pictureBox2.Image = null;

            // Select a new word
            selectedWord = words[random.Next(words.Count)];

            // Reset the displayed word with underscores
            displayWord = new string('_', selectedWord.Length).ToCharArray();
            lblWordDisplay1.Text = string.Join(" ", displayWord);

            // Clear the input textbox
            txtbox.Clear();
        }

        private void UpdateHangmanImage()
        {

            incorrectGuess++;
            switch (incorrectGuess)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources.pic1_removebg_preview;
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.pic2_removebg_preview;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources.pic3_1_removebg_preview;
                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources.pic4_removebg_preview;
                    break;
                case 5:
                    pictureBox2.Image = Properties.Resources.pic5_1_removebg_preview;
                    break;
                case 6:
                    pictureBox2.Image = Properties.Resources.pic6_1_removebg_preview;
                    break;
                case 7:
                    pictureBox2.Image = Properties.Resources.pic7_removebg_preview;
                    MessageBox.Show("You've lost! The word was " + selectedWord);
                    SaveScore(playerName, score);
                    num++;
                    lblNum.Text = (num + "/10");
                    if (num <= 10)
                    {
                        ResetGameState();
                    }
                    else
                    {
                        SaveScore(playerName, score);
                        MessageBox.Show("Game Over. Thanks for playing!");
                        Form1 form = new Form1();
                        form.Show();
                        this.Close();
                    }
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblWordDisplay1_Click(object sender, EventArgs e)
        {

        }
        /*      private void btnStartGame_Click(object sender, EventArgs e)
              {
                  string playerName = playerName.Trim();
                  if (!string.IsNullOrEmpty(playerName))
                  {
                      FrmGame gameForm = new FrmGame(playerName);
                      gameForm.Show();
                      this.Hide();
                  }
                  else
                  {
                      MessageBox.Show("Please enter your username.");
                  }
              }*/


        private void lblScore_Click(object sender, EventArgs e)
        {
            string direct = Path.Combine(Directory.GetCurrentDirectory(), "TBoard.txt");
            if (!File.Exists(direct))
            {
                // Create the file if it does not exist
                File.Create(direct).Close(); // Ensure it's closed after creation
            }
            try
            {
                // Save score in the format: "Game Number: Score"
                File.AppendAllText(direct, $"Game {num}: {score}{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving score: {ex.Message}");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
            SaveScore(playerName, score);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
