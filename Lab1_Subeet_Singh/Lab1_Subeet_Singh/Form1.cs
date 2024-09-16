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
        }
    }
}
