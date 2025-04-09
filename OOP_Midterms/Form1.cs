namespace OOP_Midterms
{
    public partial class Form1 : Form
    {
        // Declare playerName and customWords as class-level variables
        public string playerName = string.Empty;
        public List<string> customWords = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        public void label1_Click(object sender, EventArgs e)
        {
            string playerName = string.Empty;

            // Create and show the input box form
            using (InputBoxForm inputBox = new InputBoxForm("Please enter your username or player name:"))
            {
                if (inputBox.ShowDialog() == DialogResult.OK)
                {
                    playerName = inputBox.UserInput; // Get the input
                }
                else
                {
                    MessageBox.Show("Player name is required to start the game.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if no name is entered
                }
            }

            // Pass playerName when creating FormAddwords
            FormAddwords wordEntryForm = new FormAddwords(playerName);
            wordEntryForm.ShowDialog(); // Show dialog

            // Retrieve custom words
            customWords = wordEntryForm.CustomWords;

            if (customWords.Count > 0)
            {
                FrmGame gameForm = new FrmGame(playerName);
                gameForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please add at least one word to start the game.", "No Words Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        private void lblNewGame_Click(object sender, EventArgs e)
        {
            FrmNewGame frmng = new FrmNewGame();
            frmng.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblAddword_Click(object sender, EventArgs e)
        {
            /*(FormAddwords frmScoreboard = new FormAddwords();
            frmScoreboard.Show();
            this.Hide();*/

            string playerName = string.Empty;

            // Create and show the input box form
            using (InputBoxForm inputBox = new InputBoxForm("Please enter your username or player name:"))
            {
                if (inputBox.ShowDialog() == DialogResult.OK)
                {
                    playerName = inputBox.UserInput; // Get the input
                }
                else
                {
                    MessageBox.Show("Player name is required to start the game.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if no name is entered
                }
            }

            // Pass playerName when creating FormAddwords
            FormAddwords wordEntryForm = new FormAddwords(playerName);
            wordEntryForm.ShowDialog(); // Show dialog

            // Retrieve custom words and store them in the class-level customWords variable
            customWords = wordEntryForm.CustomWords;

            // Retrieve custom words
            /*  List<string> customWords = wordEntryForm.CustomWords;

              if (customWords.Count > 0)
              {
                  FrmGame gameForm = new FrmGame(playerName, customWords);
                  gameForm.Show();
                  this.Hide();
              }
              else
              {
                  MessageBox.Show("Please add at least one word to start the game.", "No Words Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              }*/
        }

        private void lblStartGame_Click(object sender, EventArgs e)
        {
            FrmNewGame frmNewGame = new FrmNewGame();
            frmNewGame.Show();
            this.Hide();

            /*FrmGame gameForm = new FrmGame(customWords);
            gameForm.Show();
            this.Hide();*/

            /* string playerName = string.Empty;

             // Create and show the input box form
             using (InputBoxForm inputBox = new InputBoxForm("Please enter your username or player name:"))
             {
                 if (inputBox.ShowDialog() == DialogResult.OK)
                 {
                     playerName = inputBox.UserInput; // Get the input
                 }
                 else
                 {
                     MessageBox.Show("Player name is required to start the game.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     return; // Exit the method if no name is entered
                 }
             }

             // Pass playerName when creating FormAddwords
             FormAddwords wordEntryForm = new FormAddwords(playerName);
             wordEntryForm.ShowDialog(); // Show dialog

             // Retrieve custom words
             List<string> customWords = wordEntryForm.CustomWords;

             if (customWords.Count > 0)
             {
                 FrmGame gameForm = new FrmGame(playerName, customWords);
                 gameForm.Show();
                 this.Hide();
             }
             else
             {
                 MessageBox.Show("Please add at least one word to start the game.", "No Words Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
            */

            // Assuming playerName and customWords are already set when btnAddwords is clicked
            /* if (!string.IsNullOrEmpty(playerName) && customWords != null && customWords.Count > 0)
             {
                 FrmGame gameForm = new FrmGame(playerName, customWords);
                 gameForm.Show();
                 this.Hide();
             }
             else
             {
                 MessageBox.Show("Please make sure you have entered a player name and added custom words before starting the game.",
                                 "Missing Information",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
             }*/
            /* FormAddwords wordEntryForm = new FormAddwords(playerName);
             if (wordEntryForm.ShowDialog() == DialogResult.OK)
             {
                 // Retrieve player name and custom words after the dialog is closed
                 playerName = wordEntryForm.PlayerName;  // if you store player name in FormAddwords
                 customWords = wordEntryForm.CustomWords; // this should update customWords correctly
             }

             if (!string.IsNullOrEmpty(playerName) && customWords.Count > 0)
             {
                 /*  FrmGame gameForm = new FrmGame(playerName, customWords);
                   gameForm.Show();
                   this.Hide();*/
            /*  FrmGame gameForm = new FrmGame(playerName, customWords);
              gameForm.Show();
              this.Hide();
          }
          else
          {
              MessageBox.Show("Please make sure you have entered a player name and added custom words before starting the game.",
                "Missing Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

              /* MessageBox.Show("Please make sure you have entered a player name and added custom words before starting the game.",
                               "Missing Information",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);*/
            //}

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmScoreboard scoreboard = new FrmScoreboard();
            scoreboard.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomWords_Click(object sender, EventArgs e)
        {
            FrmcustomWords words = new FrmcustomWords();
            words.Show();
            this.Hide();
        }
    }
}
