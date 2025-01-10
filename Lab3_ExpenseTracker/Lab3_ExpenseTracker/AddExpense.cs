using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_ExpenseTracker
{
    public partial class AddExpense : Form
    {
        //List for Expense objects
        List<Expense> expenses;
        public AddExpense(List<Expense> expenses)
        {
            InitializeComponent();
            //make the list accessible
            this.expenses = expenses;
        }

        /// <summary>
        /// Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Add new expense to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddExpense_Click(object sender, EventArgs e)
        {
            //Check if all the values are valid
            if (dateTimePicker.Value != null && textBoxDescription.Text != string.Empty && (double)numericUpDownAmount.Value > 0)
            {
                //add the expense to the list
                expenses.Add(new Expense(dateTimePicker.Value, textBoxDescription.Text, (double)numericUpDownAmount.Value));
                //close the form
                this.Close();
            }
            else
                //if values are invalid display an error messagebox
                MessageBox.Show("Please Input valid values\nDescription can't be empty\nAmount must be a positive value");
        }
    }
}
