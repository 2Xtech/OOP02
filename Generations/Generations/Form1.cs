using System.Drawing;


namespace Generations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        /*Prompting the user to select their birthdate
         *Based on the input display the:
         *  Generation Name, Generation motto, A bitmap representing the generation
         *
         * Has a clear button to reset the date
         * And a Result button to display the results
         */


        // Event handler: mouseClick on button ShowResult
        private void buttonShowResult_Click(object sender, EventArgs e)
        {
            //Initialising an icon
            Icon genIcon = Properties.Resources.boomer;

            // Get the birthYear from the dateTimePicker
            int birthYear = dateTimePickerBirthDate.Value.Year;

            //if the year is less 1945
            if (birthYear <= 1945)
            {
                //change the generationName text to 'Silent Generation'
                labelGenerationName.Text = "Silent Generation";
                //Get the icon for silentGen
                genIcon = Properties.Resources.silentGen;
                //Update the motto to 'Still GOINGGG!!!'
                labelGenerationMotto.Text = "Still GOINGGG!!!";
            }
            // if Year is between 1946 and 1964
            else if (birthYear <= 1964)
            {
                //Update generation name to 'Baby Boomer'
                labelGenerationName.Text = "Baby Boomer";
                //Get the icon for Baby Boomer
                genIcon = Properties.Resources.boomer;
                //Update the motto to 'We rocked the world—literally!'
                labelGenerationMotto.Text = "We rocked the world—literally!";
            }
            else if (birthYear <= 1980)
            {
                //Update generation name to 'Generation X
                labelGenerationName.Text = "Generation X";
                //Get the icon for Generation X
                genIcon = Properties.Resources.genX;
                //Update the motto to "Why ask for help when you can DIY?"
                labelGenerationMotto.Text = "Why ask for help when you can DIY?";
            }
            else if (birthYear <= 1996)
            {
                //Update generation name to 'Millenial'
                labelGenerationName.Text = "Millenial";
                //Get the icon for Millenial
                genIcon = Properties.Resources.millenial;
                //Update the motto to "Wi-Fi, coffee, change the world—repeat."
                labelGenerationMotto.Text = "Wi-Fi, coffee, change the world—repeat.";
            }
            else if (birthYear <= 2012)
            {
                //Update generation name to 'Gen Z'
                labelGenerationName.Text = "Gen Z";
                //Get the icon for Gen Z
                genIcon = Properties.Resources.genZ;
                //Update the motto to "If it’s not trending, does it even exist?"
                labelGenerationMotto.Text = "If it’s not trending, does it even exist?";
            }
            else if (birthYear <= 2028)
            {
                //Update generation name to 'Gen Alpha'
                labelGenerationName.Text = "Gen Alpha";
                //Get the icon for Gen Alpha
                genIcon = Properties.Resources.genAlpha;
                //Update the motto to "Born swiping, destined for world domination (virtual, not real)."
                labelGenerationMotto.Text = "Born swiping, destined for world domination\n(virtual, not real).";
            }

            //update the Image in the pictureBoxGeneration by converting genIcon using ToBitmap method
            pictureBoxGeneration.Image = genIcon.ToBitmap();

        }

        //Button to reset the date in dateTimePickerBirthDate
        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Change the Value to the MaxDate, i.e. the date the solution was created.
            dateTimePickerBirthDate.Value = dateTimePickerBirthDate.MaxDate;
        }
    }
}
