using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_TicTacToe
{
    public partial class Form1 : Form
    {
        // Game variables for managing the current turn, turn count, and scores for each player.
        string turn;
        int turnCount, xScore, oScore;

        // Color settings for players X and O
        Color xColor = Color.Tomato;
        Color oColor = Color.DarkBlue;

        // Constructor to initialize the form and settings
        public Form1()
        {
            InitializeComponent();
            label1.ForeColor = xColor;
            label2.ForeColor = oColor;
            disableBoard(); // Disable the board at the start
        }

        // Load event handler (currently unused)
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Method to start the game once both player names are entered
        private void GameStart()
        {
            enableBoard(); // Enable the game board for play
            turnCount = 0; // Reset turn count
            xScore = 0;    // Reset X player's score
            oScore = 0;    // Reset O player's score
            textBoxPlayerX.Enabled = false; // Disable the player name text boxes
            textBoxPlayerO.Enabled = false;
            labelTurn.Text = $"{textBoxPlayerX.Text}'s turn"; // Display the first player's turn
        }

        // Event handler for when text is entered in either player name textbox
        private void textBoxPlayer_TextChanged(object sender, EventArgs e)
        {
            // Start the game automatically once both names are filled in
            if (textBoxPlayerX.Text != "" && textBoxPlayerO.Text != "")
            {
                GameStart();
            }
        }

        // Enable the game board for playing
        private void enableBoard()
        {
            foreach (Control btn in tableLayoutPanelGame.Controls)
            {
                Button button = btn as Button;
                button.Enabled = true; // Enable each button
                button.Text = "";      // Clear the button text
                button.BackColor = Color.White; // Reset the button colour
                button.ForeColor = Color.White; // Set the forecolor
            }
            turn = "X"; // X always goes first
        }

        // Disable the game board to prevent playing
        private void disableBoard()
        {
            foreach (Control btn in tableLayoutPanelGame.Controls)
            {
                Button button = btn as Button;
                button.Enabled = false; // Disable each button
            }
        }

        // Handle button click for the game board
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Set the clicked button's text and color based on the current player's turn
            if (turn == "X")
            {
                button.BackColor = xColor;
                button.ForeColor = Color.White;
                button.Text = "X";
                turn = "O"; // Switch to O's turn
            }
            else
            {
                button.BackColor = oColor;
                button.Text = "O";
                turn = "X"; // Switch to X's turn
            }

            button.Enabled = false; // Disable the button after it has been clicked
            turnCount++; // Increment the turn count

            bool Won = false; // Flag to track if someone has won

            // Check for a winner after turn 5 (the earliest possible win condition)
            if (turnCount >= 5 && turnCount < 9)
            {
                string winner = Winner(); // Check for a winner

                // If X wins
                if (winner == "X")
                {
                    labelTurn.Text = $"{textBoxPlayerX.Text} Won"; // Display X as the winner
                    xScore++; // Increment X's score
                    textBoxXScore.Text = $"{xScore}"; // Update the score display
                    Won = true; // Set won flag
                }
                // If O wins
                else if (winner == "O")
                {
                    labelTurn.Text = $"{textBoxPlayerO.Text} Won"; // Display O as the winner
                    oScore++; // Increment O's score
                    textBoxOScore.Text = $"{oScore}"; // Update the score display
                    Won = true; // Set won flag
                }
            }
            // If it's a draw
            else if (turnCount == 9)
            {
                string winner = Winner(); // Check for a winner

                // If X wins
                if (winner == "X")
                {
                    labelTurn.Text = $"{textBoxPlayerX.Text} Won"; // Display X as the winner
                    xScore++; // Increment X's score
                    textBoxXScore.Text = $"{xScore}"; // Update the score display
                    Won = true; // Set won flag
                }
                // If O wins
                else if (winner == "O")
                {
                    labelTurn.Text = $"{textBoxPlayerO.Text} Won"; // Display O as the winner
                    oScore++; // Increment O's score
                    textBoxOScore.Text = $"{oScore}"; // Update the score display
                    Won = true; // Set won flag
                }
                else
                {
                labelTurn.Text = "It's a draw"; // Display draw message
                disableBoard(); // Disable the board
                buttonNextRound.Visible = true; // Show the "Next Round" button   
                }
            }
            // Update the label to indicate the next player's turn
            else
                labelTurn.Text = turn == "X" ? $"{textBoxPlayerX.Text}'s turn" : $"{textBoxPlayerO.Text}'s turn";

            // If the game is won, disable the board and update the winner label
            if (Won)
            {
                disableBoard(); // Disable the board
                buttonNextRound.Visible = true; // Show the "Next Round" button

                // Update the winner display based on current scores
                if (xScore == oScore)
                {
                    labelWinner.Text = "-"; // Display a tie
                    labelWinner.ForeColor = Color.White; // Set tie color
                }
                else
                {
                    labelWinner.Text = xScore > oScore ? "X" : "O"; // Display the leader (X or O)
                    labelWinner.ForeColor = xScore > oScore ? xColor : oColor; // Set the winner color
                }
            }
        }

        // Event handler for starting the next round
        private void buttonNextRound_Click(object sender, EventArgs e)
        {
            buttonNextRound.Visible = false; // Hide the "Next Round" button
            turnCount = 0; // Reset the turn count
            enableBoard(); // Re-enable the game board
            labelTurn.Text = $"{textBoxPlayerX.Text}'s turn"; // Reset the turn label
        }

        // Check for a winner by examining the game board
        private string Winner()
        {
            // Horizontal wins
            if (button1.Text == button2.Text && button2.Text == button3.Text && !button1.Enabled)
                return button1.Text;
            else if (button4.Text == button5.Text && button5.Text == button6.Text && !button4.Enabled)
                return button4.Text;
            else if (button7.Text == button8.Text && button8.Text == button9.Text && !button7.Enabled)
                return button7.Text;

            // Vertical wins
            else if (button1.Text == button4.Text && button4.Text == button7.Text && !button1.Enabled)
                return button1.Text;
            else if (button2.Text == button5.Text && button5.Text == button8.Text && !button2.Enabled)
                return button2.Text;
            else if (button3.Text == button6.Text && button6.Text == button9.Text && !button3.Enabled)
                return button3.Text;

            // Diagonal wins
            else if ((button1.Text == button5.Text && button5.Text == button9.Text && !button1.Enabled) ||
                     (button3.Text == button5.Text && button5.Text == button7.Text && !button3.Enabled))
                return button5.Text;

            // If no winner, return an empty string
            return "";
        }
    }
}
