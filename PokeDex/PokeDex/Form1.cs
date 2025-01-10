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

namespace PokeDex
{
    public partial class Form1 : Form
    {
        // API URL constants for fetching Pokémon data
        const string UrlPokemon = "https://pokeapi.co/api/v2/pokemon/";
        const string UrlAllPokemon = "https://pokeapi.co/api/v2/pokemon?limit=100000&offset=0";

        /// <summary>
        /// Send a request to the provided URL and return a JSON string as response.
        /// </summary>
        /// <param name="url">URL to send request to.</param>
        /// <returns>JSON string response from the API.</returns>
        private string HttpRequest(string url)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(url).Result; // .Result makes the call synchronous
            return response.Content.ReadAsStringAsync().Result; // Returns the response content as a JSON string
        }

        /// <summary>
        /// Populate the ComboBox with all the Pokémon names from the API.
        /// </summary>
        private void LoadAllPokemon()
        {
            // Make a request to fetch all Pokémon data and deserialize the response into an AllPokemon object
            string response = HttpRequest(UrlAllPokemon);
            AllPokemon allPokemon = JsonSerializer.Deserialize<AllPokemon>(response);

            // Set the maximum value for the numeric UpDown control based on the number of Pokémon
            numericUpDownPokemonID.Maximum = allPokemon.pokeArray.Count;

            // Add each Pokémon name to the ComboBox
            foreach (Pokemon1 pokemon in allPokemon.pokeArray)
            {
                comboBoxPokemonList.Items.Add(pokemon.Name);
            }
        }

        // Constructor for Form1
        public Form1()
        {
            InitializeComponent(); // Initializes the form components
            LoadAllPokemon(); // Loads the list of all Pokémon names when the form loads
            buttonChoose.Enabled = false; // Disables the "Choose" button initially
        }

        // Event handler for when the selected item in the ComboBox changes
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonChoose.Enabled = true; // Enable the "Choose" button when an item is selected
            numericUpDownPokemonID.Value = comboBoxPokemonList.SelectedIndex + 1; // Sync the numeric UpDown value with the selected index
        }

        // Event handler for when the value in the numeric UpDown control changes
        private void numericUpDownPokemonID_ValueChanged(object sender, EventArgs e)
        {
            comboBoxPokemonList.SelectedIndex = (int)numericUpDownPokemonID.Value - 1; // Sync the ComboBox index with the numeric UpDown value
        }

        // Event handler for when the "Choose" button is clicked
        private void buttonChoose_Click(object sender, EventArgs e)
        {
            // Get the name of the selected Pokémon from the ComboBox
            string selectedPokemonName = comboBoxPokemonList.SelectedItem.ToString();

            // Create a new instance of the PokemonInfo form with the selected Pokémon name and show it
            PokemonInfo pokemonInfo = new PokemonInfo(selectedPokemonName);
            pokemonInfo.Show();
        }

        // Event handler for when the text in the ComboBox is updated (used to disable the "Choose" button)
        private void comboBoxPokemonList_TextUpdate(object sender, EventArgs e)
        {
            buttonChoose.Enabled = false; // Disable the "Choose" button when the ComboBox text is updated
        }
    }
}
