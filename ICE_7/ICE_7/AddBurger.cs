using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICE_7
{
    public partial class AddBurger : Form
    {
        //Burger list
        List<Burger> burgerList;
        public AddBurger(List<Burger> burgerList)
        {
            InitializeComponent();
            //Passing the burgerList to be used
            this.burgerList = burgerList;
        }

        /// <summary>
        /// Closes the AddBurger form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Adds the Burger to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            //Check if the name is empty
            //if no, add the burger to the list and close the form
            if (textBoxBurgerName.Text != string.Empty)
            { 
                Burger newBurger = new Burger(textBoxBurgerName.Text, (double)numericUpDownPrice.Value);
                burgerList.Add(newBurger);
                Close();
            }
            else
                //if yes, display a messageBox with the error.
                MessageBox.Show("Your Burger must have a name");
        }
    }
}
