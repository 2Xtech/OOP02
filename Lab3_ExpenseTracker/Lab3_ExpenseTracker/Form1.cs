using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_ExpenseTracker
{
    public partial class Form1 : Form
    {
        //intialise the list of expenses
        List<Expense> expenses = new List<Expense>();
        //intialise a double to store total expenses
        double Expenses = 0;
        public Form1()
        {
            InitializeComponent();

            expenses.Add(new Expense(new DateTime(2024, 11, 1), "Groceries", 150.75));
            expenses.Add(new Expense(new DateTime(2024, 11, 5), "Rent", 1200.00));
            expenses.Add(new Expense(new DateTime(2024, 11, 10), "Utilities", 100.50));
            expenses.Add(new Expense(new DateTime(2024, 11, 12), "Internet", 50.00));
            expenses.Add(new Expense(new DateTime(2024, 11, 15), "Transportation", 75.30));
            //Update the GUI
            UpdateGUI();
        }

        /// <summary>
        /// Update the dataGridView of expenses
        /// </summary>
        void UpdateGUI()
        {
            //set Expenses to 0
            Expenses = 0;
            //Clear the datagrid
            dataGridViewExpenses.Rows.Clear();
            //check the list to not be empty
            if (expenses != null) 
            {
                //for each expense in the list add a row to the datagrid
                foreach (Expense expense in expenses)
                {
                    dataGridViewExpenses.Rows.Add(expense.getDate(),expense.getDescription(),expense.getAmount());
                    //add the amount to the total expenses
                    Expenses += expense.getAmount();
                }
            }
            //Format the amount column of the datagrid
            dataGridViewExpenses.Columns[2].DefaultCellStyle.Format = "C2";
            dataGridViewExpenses.Columns[2].DefaultCellStyle.FormatProvider = new CultureInfo("en-US");
            //Update the totalexpenses textbox
            textBoxExpenses.Text = "$" + Expenses.ToString("F2");
            //Update the netbalance textbox
            UpdateBudget(Expenses);
        }
        /// <summary>
        /// Updates the netbalance textbox
        /// </summary>
        /// <param name="totalExpenses"></param>
        void UpdateBudget(double totalExpenses)
        {
            //Calculate netbalance
            // netBalance = budget - expenses
            double netBalance = (double)numericUpDownBudget.Value - Expenses;
            //Update the netBalance textbox and format it to 2 decimal places 
            textBoxNetBalance.Text = $"${netBalance:F2}";
            //Change colour based on if balance is positive or negative
            textBoxNetBalance.BackColor = netBalance >= 0 ? Color.Green : Color.Red;
        }

        /// <summary>
        /// removes an expense from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveExpense_Click(object sender, EventArgs e)
        {
            //check if list is empty or no expense is selected from the list
            if(expenses.Count == 0)
            { 
                //display error message
                MessageBox.Show("List is already empty"); 
            }
            else if (dataGridViewExpenses.CurrentRow == null)
            { 
                //Display error message 'no row selected'
                MessageBox.Show("No row selected");
            }
            else 
            {
                //Get the expense to be removed and store it
                Expense expenseRemove = new Expense((DateTime)dataGridViewExpenses.CurrentRow.Cells[0].Value, 
                                                    (string)dataGridViewExpenses.CurrentRow.Cells[1].Value, 
                                                    (double)dataGridViewExpenses.CurrentRow.Cells[2].Value);
                //remove the Expense from the list
                expenses.Remove(expenseRemove);
            }
            //Update the GUI
            UpdateGUI();

        }
        /// <summary>
        /// Add new expense
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddExpense_Click(object sender, EventArgs e)
        {
            //Create and display the AddExpense form
            AddExpense addExpense = new AddExpense(expenses);
            addExpense.ShowDialog();
            //Update the GUI
            UpdateGUI();
        }

        /// <summary>
        /// Updates the netbalance whenever the budget value is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownBudget_ValueChanged(object sender, EventArgs e)
        {
            //Update the netbalance
            UpdateBudget(Expenses);
        }

        private void numericUpDownBudget_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateBudget(Expenses);
        }
    }
}
