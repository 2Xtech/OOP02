using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICE_9
{
    public partial class AddVictim : Form
    {
        List<Victim> victims;
        public AddVictim(List<Victim> victims)
        {
            InitializeComponent();
            this.victims = victims;
        }
        /// <summary>
        /// Close the modal window
        /// </summary>
        private void buttonSpare_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Add the new victim to the list
        /// </summary>
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            // If the victim has no name
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("You must name your victim!", "Warning!");
                return;
            }

            // Victim has a name
            // Create a new victim object
            Victim victim = new Victim(name);

            // Add to the list of victims
            victims.Add(victim);

            // Close the dialog
            Close();
        }
    }
}
