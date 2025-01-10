using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ICE_8
{
    public partial class Form1 : Form
    {
        Button[] options;
        Random random = new Random();
        string animal;
        int score = 0;
        public Form1()
        {
            InitializeComponent();

            //Store buttons in an array
            options = new Button[] { button1, button2, button3, button4 };

            //Start the game
            ShowNextAnimal();
        }

        string GetRandomAnimal()
        {
            //get all keys
            string[] allAnimals = Zoo.animals.Keys.ToArray();
            //get random animal
            int randomIndex = random.Next(0, allAnimals.Length);
            return allAnimals[randomIndex];
        }

        void ShowNextAnimal()
        {
            timer.Start();
            progressBar1.Value = 0;
            animal = GetRandomAnimal();
            label2.Text = Zoo.animals[animal];
            do
            {
                foreach (Button button in options)
                {
                    button.Text = GetRandomAnimal();
                }
                options[random.Next(4)].Text = animal;
            }
            while (CheckForDuplicates());
        }

        bool CheckForDuplicates()
        {
            // Check if the button text matches another button's text
            foreach (Button button in options)
            {
                foreach (Button optionButton in options)
                {
                    // Duplicate found
                    if (button != optionButton && button.Text == optionButton.Text)
                    {
                        return true;
                    }
                }
            }
            // No duplicates
            return false;
        }

        /// <summary>
        /// Executed every half a second to increment progress until the game is over
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        { 
            progressBar1.PerformStep();
            // Time's up
            if (progressBar1.Value == 100)
            { 
                GameOver();
            }
        }

        /// <summary>
        /// Game Over screen: shows score and asks to play again
        /// </summary>
        void GameOver()
        {
            timer.Stop();
            // Ask if the user wants to play again
            DialogResult result = MessageBox.Show(
                $"The answer was {animal}\n" +
                $"You guessed {score} correct animals!\n\n" +
                "Play again?", "Game Over", MessageBoxButtons.YesNo);

            // Reset the score
            score = 0;

            // Chose to quit
            if (result == DialogResult.No)
            {
                Close();
            }
            // Chose to play again
            else
            {
                ShowNextAnimal();
            }
        }

        /// <summary>
        /// When an option is clicked, check if it's the right option
        /// </summary>
        private void AnyButtonClicked(object sender, EventArgs e)
        {
            // This is the clicked button
            Button option = (Button)sender;

            // Chose the right option
            if (option.Text == animal)
            {
                score++;
                ShowNextAnimal();
            }
            // Wrong option
            else
            {
                GameOver();
            }
        }
    }
}
