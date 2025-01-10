using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ICE_9
{
    public partial class Form1 : Form
    {
        const string jsonFile = "victims.json";
        List<Victim> victims = new List<Victim>();

        /// <summary>
        /// Store the victims list in a JSON file
        /// </summary>
        void SaveJsonFile()
        {
            // Serialize the victim list into a string
            string jsonString = JsonSerializer.Serialize(victims);

            // Save the string into a file
            File.WriteAllText(jsonFile, jsonString);
        }

        /// <summary>
        /// Load the victims list from the JSON file
        /// </summary>
        void LoadJsonFile()
        {
            // If the file doesn't exist, then don't load it
            if (!File.Exists(jsonFile)) return;

            // Store the file into a string
            string jsonString = File.ReadAllText(jsonFile);

            // Convert the string into an object
            victims = JsonSerializer.Deserialize<List<Victim>>(jsonString) ?? new List<Victim>();
        }

        /// <summary>
        /// Update the list in the GUI
        /// </summary>
        void UpdateListView()
        {
            // Remove all items
            listView1.Items.Clear();

            // Go through all items in the list
            foreach (Victim victim in victims)
            {
                // Add an item
                ListViewItem item = listView1.Items.Add(victim.name);

                // If checked, then also strikethrough
                item.Checked = !victim.isAlive;
            }
        }
        public Form1()
        {
            InitializeComponent();
            LoadJsonFile();
            UpdateListView();
        }

        /// <summary>
        /// Adds a new victim to the kill list
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Show the modal window
            AddVictim addVictim = new AddVictim(victims);
            addVictim.ShowDialog();
            UpdateListView();
            SaveJsonFile();
        }

        /// <summary>
        /// When we check an item, update the list in the GUI
        /// </summary>
        private void ListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            // Get the index of the item checked
            // and update the victim at the same index
            victims[e.Item.Index].isAlive = !e.Item.Checked;

            // Strikethrough when item is checked
            if (e.Item.Checked)
                e.Item.Font = new Font(e.Item.Font, e.Item.Font.Style | FontStyle.Strikeout);
            // Normal when item is unchecked
            else
                e.Item.Font = new Font(e.Item.Font, e.Item.Font.Style & ~FontStyle.Strikeout);

            SaveJsonFile();
        }

        /// <summary>
        /// Remove all "checked" victims
        /// </summary>
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // Go through all CHECKED items in the GUI
            foreach (ListViewItem item in listView1.CheckedItems)
            {
                // Go through all victims
                for (int index = 0; index < victims.Count; index++)
                {
                    // If the names match
                    if (item.Text == victims[index].name)
                    {
                        // Then remove the victim
                        victims.RemoveAt(index);
                        index--; // Adjust the index after removal
                    }
                }
            }

            // Update the GUI to match the list
            SaveJsonFile();
            UpdateListView();
        }
    }
}
