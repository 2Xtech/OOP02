using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICE_5_EmojiMatchingGame
{
    /// <summary>
    /// Choose random emoji for each square
    /// </summary>
    public partial class Form1 : Form
    {

        Label firstLabel = null;  // To hold the first clicked label
        Label secondLabel = null; // To hold the second clicked label
        private Timer peekTimer;  // Timer to hide unmatched emojis after a short interval

        const int TotalPairs = 8; // Total number of pairs in the game
        private int pairsFound = 0; // Tracks the number of pairs found

        // Method to assign random emojis to squares
        private void AssignEmojiToSquare()
        {
            // List of emoji pairs
            List<string> emojiList = new List<string>
            {
                "🤡","😺","😶‍🌫️","☠️","👻","👀","🍑","❤️",
                "🤡","😺","😶‍🌫️","☠️","👻","👀","🍑","❤️"
            };

            Random random = new Random();  // Random object to shuffle emojis
            foreach (Label square in tableLayoutPanelEmoji.Controls) // Assign each square a random emoji
            {
                square.ForeColor = square.BackColor = Color.Teal; // Hide emoji initially
                int randomIndex = random.Next(emojiList.Count); // Get random emoji index
                square.Text = emojiList[randomIndex]; // Assign random emoji
                emojiList.RemoveAt(randomIndex); // Remove assigned emoji to avoid duplicates
            }
        }

        // Constructor for the form
        public Form1()
        {
            InitializeComponent();
            AssignEmojiToSquare(); // Assign random emojis to the squares
            peekTimer = new Timer(); // Initialize the timer
            peekTimer.Interval = 1000; // Set timer interval to 1 second
            peekTimer.Tick += timeUp; // Associate timer event handler
            labelScore.Text = $"Pairs Found: {pairsFound}/{TotalPairs}"; // Initialize score label
        }

        // Event handler for the timer tick, called when time is up to hide unmatched emojis
        private void timeUp(object sender, EventArgs e)
        {
            peekTimer.Stop(); // Stop the timer
            firstLabel.ForeColor = firstLabel.BackColor; // Hide first label emoji
            secondLabel.ForeColor = secondLabel.BackColor; // Hide second label emoji
            firstLabel = null; // Reset first label
            secondLabel = null; // Reset second label
        }

        // Event handler for label clicks
        private void labelClicked(object sender, EventArgs e)
        {
            Label clickedlabel = sender as Label; // Get the clicked label

            // If label is already revealed, return without action
            if (clickedlabel.BackColor != clickedlabel.ForeColor) return;

            // If no labels have been selected
            if (firstLabel == null && secondLabel == null)
            {
                firstLabel = clickedlabel; // Set first label
                firstLabel.ForeColor = Color.Black; // Reveal emoji
            }
            // If first label is selected, select second label
            else if (firstLabel != null && secondLabel == null)
            {
                secondLabel = clickedlabel; // Set second label
                secondLabel.ForeColor = Color.Black; // Reveal emoji
                // Check if both labels match
                if (firstLabel.Text == secondLabel.Text)
                {
                    pairsFound++; // Increment pairs found count
                    labelScore.Text = $"Pairs Found: {pairsFound}/{TotalPairs}"; // Update score label
                    firstLabel = null; // Reset first label
                    secondLabel = null; // Reset second label
                }
                else
                    peekTimer.Start(); // Start timer if labels do not match
            }

            // If all pairs are found, display a winning message
            if (pairsFound == TotalPairs)
                MessageBox.Show("YAYYYY! You matched all the emojis!!");
        }

    }
}
