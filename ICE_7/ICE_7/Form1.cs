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
    public partial class Form1 : Form
    {
        //List of Burgers
        List<Burger> burgerMenu = new List<Burger>();
        public Form1()
        {
            InitializeComponent();
            // Add the intial list of burgers to the burgerMenu i.e. list of burger objects
            burgerMenu.Add(new Burger("Krabby Patty", 2.99));
            burgerMenu.Add(new Burger("Gurber", 7.99));
            burgerMenu.Add(new Burger("Rubger", 3.99));
            burgerMenu.Add(new Burger("Bergur", 5.99));
            burgerMenu.Add(new Burger("RugBear", 11.99));
            //Update the GUI after adding burgers to the list
            UpdateMenuGUI();

        }

        /// <summary>
        /// Update the datagrid so it displays the items in the list
        /// </summary>
        void UpdateMenuGUI()
        {
            //Clear the content of the datagrid
            dataGridView1.Rows.Clear();
            //Loop over the burgers in burgerMenu 
            for (int index = 0; index < burgerMenu.Count; index++)
            {
                //add each burger to the datagrid, both the name and the price
                dataGridView1.Rows.Add(
                    index + 1, 
                    burgerMenu[index].GetName(), 
                    $"${burgerMenu[index].GetPrice()}"
                    );
            }
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// Shows te Add Burger Modal Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Create a new AddBurger Object
            AddBurger addBurger = new AddBurger(burgerMenu);
            // Show the form
            addBurger.ShowDialog();
            //Update the GUI once done
            UpdateMenuGUI();
        }

        /// <summary>
        /// Removes the selected burger on the datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //Check if the menu is already empty
            //if empty display a messageBox showing the error and return
            if (burgerMenu.Count == 0) { MessageBox.Show("Menu is already empty"); return;}

            // if not empty, remove the selected burger from the list
            int burgerIndex = (int)dataGridView1.CurrentRow.Cells[0].Value - 1;
            burgerMenu.RemoveAt(burgerIndex);
            //Update the GUI after removing the burger from the list
            UpdateMenuGUI();
        }
    }
}
