namespace Lab1_Subeet_Singh
{
    public partial class FormDogYearsConverter : Form
    {
        public FormDogYearsConverter()
        {
            InitializeComponent();
        }
        //Calculate button click event
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //clear the textbox contents to start with
            textBoxDogAgeDogYears.Clear();
            //check if the input is within bounds i.e. between 0 and 40
            if ((int)numericUpDownDogAgeHumanYears.Value >= 0 && (int)numericUpDownDogAgeHumanYears.Value <= 40)
            {

                decimal dogAgeHumanYears = numericUpDownDogAgeHumanYears.Value;
                int dogAgeDogYears;
                if (dogAgeHumanYears <= 2)
                {
                    //if dog age is less than 2
                    //use the dogAge(in dog years) = humanYears*10
                    dogAgeDogYears = (int)(dogAgeHumanYears * 10);
                }
                else
                {
                    //if dog age is more than 2
                    // use the dog age(in dog years) = 4*humanYears + 12
                    dogAgeDogYears = (int)(4 * dogAgeHumanYears + 12);
                }
                //display the result in the textbox by updating the text after converting it to string
                textBoxDogAgeDogYears.Text = dogAgeDogYears.ToString();

                // display the picture and the text based on the age of the dog
                if (dogAgeHumanYears <= 1)
                {
                    // if the age is less than or equal to 1
                    // change the text to "Your Dog is still a puppy!!!"
                    // change the image to an image of a puppy
                    labelResultText.Text = "Your Dog is still a puppy!!!";
                    pictureBoxDog.Image = Properties.Resources.Puppy.ToBitmap();
                }
                else if (dogAgeHumanYears <= 7) 
                {
                    // if the age is between 1 and 7
                    // change the text to "Your Dog is fully grown!!!"
                    // change the image to an image of a fully grown dog
                    labelResultText.Text = "Your Dog is fully grown!!!";
                    pictureBoxDog.Image = Properties.Resources.FullyGrownDog.ToBitmap();
                }
                else
                {
                    // if the age is more than 7
                    // change the text to "Your Dog is a top G now!!!"
                    // change the image to an image of an elder dog
                    labelResultText.Text = "Your Dog's a top G now!!!";
                    pictureBoxDog.Image = Properties.Resources.ElderDog.ToBitmap();
                }
            }
            else
            {
                //if the input in invalid display an error message using the tooltip
                toolTipError.Show("ERROR: Please input a valid number between 0 and 40", numericUpDownDogAgeHumanYears);
            }
        }

        //Reset button click event
        private void buttonReset_Click(object sender, EventArgs e)
        {
            //clear the textbox content
            textBoxDogAgeDogYears.Clear();
            //set the numericUpDown value to 0
            numericUpDownDogAgeHumanYears.Value = 0;
            //Hide the error tooltip
            toolTipError.Hide(numericUpDownDogAgeHumanYears);
        }
    }
}
