using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugSquishingGame
{
    
    public partial class Form1 : Form
    {
        // Bitmap Array to store the bug images
        Bitmap[] bugImages =
        {
            Properties.Resources.BugImage1,
            Properties.Resources.BugImage2,
            Properties.Resources.BugImage3,
            Properties.Resources.BugImage4,
            Properties.Resources.BugImage5,
            Properties.Resources.BugImage6,
            Properties.Resources.BugImage7,
        };

        //Constant to store the total number of bug images
        const int TotalBugImages = 7;

        // Variable to store the number of bug squashed
        int bugsSquashed = 0;

        //Constant to store the total game time in seconds
        const int TotalGameTime = 10;

        //Variable to store the time left; initialised as 0
        int gameTimeLeft = 0;
        //Integer to store the last image's index
        int lastBugImageIndex = -1;

        //Initialising a random
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void panelBugSpawn_Paint(object sender, PaintEventArgs e)
        {

        }
        
        //Function to spawn bugs
        void bugSpawn()
        {
            // set the image number as lastBugImageIndex
            int bugImageNumber = lastBugImageIndex;

            //Get a random point to spawn the bug
            Point bugSpawnPoint = new Point(random.Next(0, panelBugSpawn.Width - pictureBoxBug.Width), random.Next(0, panelBugSpawn.Height - pictureBoxBug.Height));

            //Get a random image to set as bug
            //Loop till you get a different image
            while (bugImageNumber == lastBugImageIndex)
            {
                //update bugImageNumber to keep track of the current index
                bugImageNumber = random.Next(0,TotalBugImages-1);
            }

            //Update the location of the bug
            pictureBoxBug.Location = bugSpawnPoint;
            //Update the bug image
            pictureBoxBug.Image = bugImages[bugImageNumber];
            //Make the bug visible
            pictureBoxBug.Visible = true;
        }

        //Event Listener for mouse down on bug
        private void pictureBoxBug_MouseDown(object sender, MouseEventArgs e)
        {
            //Increase the number of bugs squashed by 1
            bugsSquashed++;
            //Update the Score label
            labelScoreCounter.Text = $"SCORE: {bugsSquashed}";
            //Update the blood splash location
            pictureBoxBlood.Location = pictureBoxBug.Location;
            //Hide the bug
            pictureBoxBug.Visible = false;
            //Make the blood visible
            pictureBoxBlood.Visible = true;
            //Call the bug spawn function
            bugSpawn();
        }

        //Event Listener for Start button
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Hide the Start Button
            buttonStart.Visible = false;
            //Set the time left as TotalGameTime
            gameTimeLeft = TotalGameTime;
            //Set the score to 0
            bugsSquashed = 0;
            //Update the Time Left and Score Labels
            labelGameTime.Text = $"TIME LEFT: {gameTimeLeft}";
            labelScoreCounter.Text = "SCORE: 0";
            //Start the timer
            timerGameTime.Start();
            //Call the bug spawn function to spawn bug
            bugSpawn();
        }

        //Event Listener for everytime the timer Ticks
        //Ticks every 1 second
        void TimerGameTime_Tick(object sender, EventArgs e)
        {
            //Decrease the time left by 1
            gameTimeLeft--;
            //Upate the GameTime label
            labelGameTime.Text = $"TIME LEFT: {gameTimeLeft}";
            //Check if the Time left is 0
            if (gameTimeLeft == 0)
            {
                //if yes
                //Call the GameEnd function to end the game
                GameEnd();
            }


        }


        //Function to end the game once the time runs out
        void GameEnd ()
        {
            //Hide the bug and the blood pictureboxes
            pictureBoxBug.Visible= false;
            pictureBoxBlood.Visible= false;
            //Stop the timer
            timerGameTime.Stop();
            //Make the start button visible
            buttonStart.Visible = true;
        }
    }
}
