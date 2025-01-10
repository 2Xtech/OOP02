using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StrongPasswordGenerator
{
    public partial class Form1 : Form
    {
        // Constants defining character sets for password generation
        const string LowerCase = "abcdefghijklmnopqrstuvwxyz";
        const string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string Digits = "0123456789";
        const string SpecialChars = "~!@#$%^&*()-=_+[]{}|;:,.<>?";

        // Boolean flags to track password criteria
        bool isLower, isUpper, isDigit, isSpecial, isTenChars;

        // Constructor to initialize the form and disable progress bar style
        public Form1()
        {
            InitializeComponent();
            ProgressBarExtensions.DisableStyle(progressBarPasswordStrength);
        }

        // Event handler for the "Generate Random Password" button click
        private void buttonRandomPassword_Click(object sender, EventArgs e)
        {
            GeneratePassword(); // Generate a new password
            UpdateProgressColours(); // Update the UI for password strength
        }

        // Event handler for when the password text box content changes
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            CheckPasswordStrength(textBoxPassword.Text); // Check the strength of the entered password
            UpdateProgressColours(); // Update the UI based on password strength
        }

        // Empty Paint event handler for tableLayoutPanel1 (can be customized if needed)
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Update the labels and progress bar colors based on password strength criteria
        private void UpdateProgressColours()
        {
            // Change the background color of labels based on criteria fulfillment
            label4.BackColor = isLower ? Color.Green : Color.Firebrick;
            label5.BackColor = isUpper ? Color.Green : Color.Firebrick;
            label6.BackColor = isDigit ? Color.Green : Color.Firebrick;
            label7.BackColor = isSpecial ? Color.Green : Color.Firebrick;
            label8.BackColor = isTenChars ? Color.Green : Color.Firebrick;

            // Reset and update progress bar value based on criteria fulfillment
            progressBarPasswordStrength.Value = 0;
            progressBarPasswordStrength.Value += isLower ? 20 : 0;
            progressBarPasswordStrength.Value += isUpper ? 20 : 0;
            progressBarPasswordStrength.Value += isDigit ? 20 : 0;
            progressBarPasswordStrength.Value += isSpecial ? 20 : 0;
            progressBarPasswordStrength.Value += isTenChars ? 20 : 0;

            // Set progress bar color based on strength level
            if (progressBarPasswordStrength.Value == 20)
                progressBarPasswordStrength.ForeColor = Color.Red;
            else if (progressBarPasswordStrength.Value == 40)
                progressBarPasswordStrength.ForeColor = Color.Tomato;
            else if (progressBarPasswordStrength.Value == 60)
                progressBarPasswordStrength.ForeColor = Color.Orange;
            else if (progressBarPasswordStrength.Value == 80)
                progressBarPasswordStrength.ForeColor = Color.Yellow;
            else if (progressBarPasswordStrength.Value == 100)
                progressBarPasswordStrength.ForeColor = Color.Lime;
        }

        // Function to generate a random password meeting the criteria
        private void GeneratePassword()
        {
            string password = ""; // Initialize password string
            Random random = new Random(); // Random number generator
            bool isStrong; // Boolean to track if the generated password meets criteria
            string[] criteria = { LowerCase, UpperCase, Digits, SpecialChars }; // Character sets

            do
            {
                password = "";  // Reset password each time

                // Generate a 10-character password
                for (int count = 0; count < 10; count++)
                {
                    // Select a random character set
                    string criterion = criteria[random.Next(criteria.Length)];
                    // Pick a random character from the selected set
                    char letter = criterion[random.Next(criterion.Length)];
                    // Append the character to the password
                    password += letter;
                }

                // Check if the generated password meets all strength criteria
                CheckPasswordStrength(password);
                isStrong = isLower && isUpper && isSpecial && isDigit && isTenChars;

            } while (!isStrong); // Repeat until a strong password is generated

            textBoxPassword.Text = password; // Display the generated password
        }

        // Event handler to toggle password visibility based on the checkbox state
        private void checkBoxViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxViewPassword.Checked == true)
            {
                checkBoxViewPassword.BackgroundImage = Properties.Resources.Visible; // Show the password
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                checkBoxViewPassword.BackgroundImage = Properties.Resources.Hidden; // Hide the password
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        // Function to evaluate password strength based on various criteria
        private void CheckPasswordStrength(string password)
        {
            // Reset all criteria flags
            isLower = false;
            isUpper = false;
            isDigit = false;
            isSpecial = false;
            isTenChars = false;

            // Loop through each character in the password
            foreach (char letter in password)
            {
                if (LowerCase.Contains(letter))
                    isLower = true; // Password contains lowercase letter
                else if (UpperCase.Contains(letter))
                    isUpper = true; // Password contains uppercase letter
                else if (Digits.Contains(letter))
                    isDigit = true; // Password contains digit
                else if (SpecialChars.Contains(letter))
                    isSpecial = true; // Password contains special character
            }

            // Check if the password is at least 10 characters long
            if (password.Length >= 10)
                isTenChars = true;
        }
    }
}