using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ExpenseTracker
{
    public class Expense
    {
        //private variable for the class
        private DateTime date;
        private string description;
        private double amount;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="date"></param>
        /// <param name="description"></param>
        /// <param name="amount"></param>
        public Expense(DateTime date, string description, double amount)
        {
            this.date = date;
            this.description = description;
            this.amount = amount;
        }

        //Getters for the class
        public DateTime getDate() { return date; }
        public string getDescription() { return description; }
        public double getAmount() { return amount; }

        //Override the Equals operation
        /*
         I had to do this to be able to sort the expenses by any of the columns.

         It makes the Equals compare the object by values rather than just the pointer.
         */
        public override bool Equals(object obj)
        {
            if (obj is Expense expense)
            {
                return date == expense.date &&
                       description == expense.description &&
                       amount == expense.amount;
            }
            return false;
        }

        //Overriding GetHashCode
        /*Suggested by Visual Studio*/
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
