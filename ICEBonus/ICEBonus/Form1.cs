using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ICEBonus
{
    public partial class Form1 : Form
    {
        // API URL constants
        const string UrlPokemon = "https://pokeapi.co/api/v2/pokemon/";
        const string UrlAllPokemon = "https://pokeapi.co/api/v2/pokemon?limit=100000&offset=0";

        /// <summary>
        /// Send a request to the provided URL and return a JSON string as response
        /// </summary>
        /// <param name="url">URL to send request to</param>
        /// <returns>JSON string response</returns>
        string HttpRequest(string url)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(url).Result;
            return response.Content.ReadAsStringAsync().Result;
        }

        /// <summary>
        /// Populate the combobox with all the Pokemon names
        /// </summary>
        private void LoadAllPokemon()
        {
            // Request all Pokemon names and IDs
            string response = HttpRequest(UrlAllPokemon);

            // Deserialize the JSON string into an AllPokemon object
            AllPokemon allPokemon = JsonSerializer.Deserialize<AllPokemon>(response);

            // Set the maximum Pokemon number
            numericUpDown.Maximum = allPokemon.count;

            // Add all Pokemon names to the ComboBox
            foreach (Pokemon pokemon in allPokemon.pokeArray)
            {
                comboBox.Items.Add(pokemon.name);
            }
        }

        public Form1()
        {
            InitializeComponent();
            LoadAllPokemon();
        }

        /// <summary>
        /// Fetch information about the chosen Pokemon and show its image
        /// </summary>
        private void ChooseYouButton_Click(object sender, EventArgs e)
        {
            // Request details about the selected Pokemon
            string response = HttpRequest(UrlPokemon + comboBox.Text);

            // Deserialize the JSON string into a Pokemon object
            Pokemon pokemon = JsonSerializer.Deserialize<Pokemon>(response);

            // Display Pokemon ID and Name
            labelPokemonName.Text = pokemon.id + " - " + pokemon.name;

            // Show the Pokemon picture
            pictureBox1.ImageLocation = pokemon.sprites.frontDefault;
        }

        /// <summary>
        /// Synchronizes the Pokemon number and name
        /// </summary>
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            comboBox.SelectedIndex = (int)numericUpDown.Value - 1;
        }

        /// <summary>
        /// Synchronizes the Pokemon name and number
        /// </summary>
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown.Value = comboBox.SelectedIndex + 1;
        }

        /// <summary>
        /// Reject invalid Pokemon names
        /// </summary>
        private void ComboBox1_Leave(object sender, EventArgs e)
        {
            // Get the previous name from the numericUpDown
            string previousName = comboBox.Items[(int)numericUpDown.Value - 1].ToString();

            // Invalid name, revert to the previous
            if (!comboBox.Items.Contains(comboBox.Text))
            {
                comboBox.Text = previousName;
            }
        }
    }
}
