using System.Drawing;


namespace Generations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowResult_Click(object sender, EventArgs e)
        {
            

            int BirthYear = dateTimePickerBirthDate.Value.Year;
            if (BirthYear <= 1945)
            {
                labelGenerationName.Text = "Silent Generation";
                 
                labelGenerationMotto.Text = "Still GOINGGG!!!";
            }
            else if (BirthYear <= 1964)
            {
                labelGenerationName.Text = "Baby Boomer";
              
                labelGenerationMotto.Text = "We rocked the world—literally!";
            }
            else if (BirthYear <= 1980)
            {
                labelGenerationName.Text = "Generation X";
                
                labelGenerationMotto.Text = "Why ask for help when you can DIY?";
            }
            else if (BirthYear <= 1996)
            {
                labelGenerationName.Text = "Millenial";

                labelGenerationMotto.Text = "Wi-Fi, coffee, change the world—repeat.";
            }
            else if (BirthYear <= 2012)
            {
                labelGenerationName.Text = "Gen Z";
                
                labelGenerationMotto.Text = "If it’s not trending, does it even exist?";
            }
            else if (BirthYear <= 2028)
            {
                labelGenerationName.Text = "Gen Alpha";
               
                labelGenerationMotto.Text = "Born swiping, destined for world domination\n(virtual, not real).";
            }

       

        }
    }
}
