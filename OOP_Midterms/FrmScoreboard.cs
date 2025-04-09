using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace OOP_Midterms
{
    public partial class FrmScoreboard : Form
    {

        public FrmScoreboard()
        {
            InitializeComponent();
        }
        string direct = Path.Combine(Directory.GetCurrentDirectory(), "TBoard.txt");

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Method to load scores into the ListView
        private void LoadScoresToListView()
        {

            try
            {
                // Clear existing items in the ListView before loading new data
                lstScore1.Items.Clear();
                string[] lines = File.ReadAllLines(direct);

                // Read all lines from the scoreboard.txt file
                var scores = new List<(string player, int score)>();


                foreach (var line in lines)
                {
                    // Split the line into player name and score
                    var parts = line.Split(new[] { " : " }, StringSplitOptions.None);
                    if (parts.Length == 2 && int.TryParse(parts[1], out int score))
                    {
                        scores.Add((parts[0].Trim(), score));
                    }
                }

                // Sort scores in descending order
                scores = scores.OrderByDescending(s => s.score).ToList();

                // Display each score with proper formatting
                foreach (var (player, score) in scores)
                {
                    var listViewItem = new ListViewItem(player);  // Name goes to the first column
                    listViewItem.SubItems.Add(score.ToString());  // Score goes to the second column
                    lstScore1.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading scores: {ex.Message}");
            }
        }
        // Method to save a player's score
        private void FrmScoreboard_Load(object sender, EventArgs e)
        {
            /* string direct = Directory.GetCurrentDirectory() + "/scoreboard.txt";
                 try
                 {
                     string[] scores = File.ReadAllLines(direct);
                     lstScoreboard.DataSource = scores;
                 }
                 catch
                 {
                     MessageBox.Show("End of file");
                 }*/
            // Set up the ListView to have two columns: Name and Score
            lstScore1.View = View.Details;
            lstScore1.Columns.Add("Name", 150);  // Name column (150px wide)
            lstScore1.Columns.Add("Score", 100); // Score column (100px wide)

            LoadScoresToListView(); // Automatically load scores when the form is loaded
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            
        }

        private void lstScore1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
