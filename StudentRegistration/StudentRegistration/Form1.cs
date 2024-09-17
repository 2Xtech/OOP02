namespace StudentRegistration
{
    public partial class StudentRegistrationForm : Form
    {
        public StudentRegistrationForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        /*Summary
         *Prompt the user to enter their student details
         *Student Number, Name, Program, Duration of the Program
         *
         *validate the fields and display errors
         *
         *if all the fields are valid then display the student information using message box
         *
         */
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //Use tooltip to display errors
            //Validating the student number
            //student number should be 9 digits long
            if (maskedTextBoxStudentNumber.Text.Length < 9)
            {
                //if student number is less than 9 digits display error
                toolTipError.Show("ERROR: Student Number should be 9 digits long", maskedTextBoxStudentNumber);
            }
            //checking if the name is null or whitespace
            else if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                //display error if yes
                toolTipError.Show("ERROR: Name cannot be empty", textBoxName);
            }
            //validate the name to only contain letters
            else if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxName.Text, @"^[a-zA-Z\s]+$"))
            {
                //display error if name has invalid characters
                toolTipError.Show("ERROR: Name cannot have numbers or special characters",textBoxName);
            }
            //check if a valid program is selected
            // if not display an error using tooltip
            else if(string.IsNullOrEmpty(comboBoxProgram.Text))
            {
                toolTipError.Show("ERROR: Program cannot be empty", comboBoxProgram);
            }
            //if all the input fields are valid
            //use message box to display the student information
            else
            {
                string info = "Student Number: " + maskedTextBoxStudentNumber.Text
                            + "\nName: " + textBoxName.Text
                            + "\nProgram: " + comboBoxProgram.Text
                            + "\nDuration in semester: " + numericUpDownDurationSemester.Value;
                MessageBox.Show(info, "Student Information");
            }
        }
    }
}
