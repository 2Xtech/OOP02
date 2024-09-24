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
        const int TotalBugImages = 7;
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

        int bugsSquashed = 0;
        const int TotalGameTime = 5;
        int gameTimeLeft = 0;
        int lastBugImageIndex = -1;

        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void panelBugSpawn_Paint(object sender, PaintEventArgs e)
        {

        }

        void bugSpawn()
        {
            int bugImageNumber = lastBugImageIndex;
            Point bugSpawnPoint = new Point(random.Next(0, panelBugSpawn.Width - pictureBoxBug.Width), random.Next(0, panelBugSpawn.Height - pictureBoxBug.Height));

            while (bugImageNumber == lastBugImageIndex)
            {
                bugImageNumber = random.Next(0,TotalBugImages-1);
            }

            pictureBoxBug.Location = bugSpawnPoint;
            pictureBoxBug.Image = bugImages[bugImageNumber];
            pictureBoxBug.Visible = true;
        }

        private void pictureBoxBug_MouseDown(object sender, MouseEventArgs e)
        {
            bugsSquashed++;
            labelScoreCounter.Text = $"SCORE: {bugsSquashed}";
            pictureBoxBlood.Location = pictureBoxBug.Location;
            pictureBoxBlood.Visible = true;
            pictureBoxBug.Visible = false;
            bugSpawn();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = false;
            gameTimeLeft = TotalGameTime;
            bugsSquashed = 0;
            labelGameTime.Text = $"TIME LEFT: {gameTimeLeft}";
            labelScoreCounter.Text = "SCORE: 0";
            timerGameTime.Start();
            bugSpawn();
        }

        void TimerGameTime_Tick(object sender, EventArgs e)
        {
            gameTimeLeft--;
            labelGameTime.Text = $"TIME LEFT: {gameTimeLeft}";
            if (gameTimeLeft == 0)
            {
                GameEnd();
            }


        }

        void GameEnd ()
        {
            pictureBoxBug.Visible= false;
            pictureBoxBlood.Visible= false;
            timerGameTime.Stop();
            buttonStart.Visible = true;
        }
    }
}
