using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeDex
{
    public partial class PokemonInfo : Form
    {
        // Instance variable to hold the Pokémon object
        Pokemon pokemon;
        // String to store the name or ID of the Pokémon
        string nameId;
        // Base URL for the Pokémon API
        string urlPokemon = "https://pokeapi.co/api/v2/pokemon/";
        // Dictionary to map Pokémon types to their corresponding background and foreground colors
        Dictionary<string, (string backColor, string foreColor)> pokemonTypeColors = new Dictionary<string, (string, string)>
        {
            { "Bug", ("green", "black") },
            { "Dark", ("black", "white") },
            { "Dragon", ("blue", "white") },
            { "Electric", ("yellow", "black") },
            { "Fairy", ("pink", "black") },
            { "Fighting", ("red", "white") },
            { "Fire", ("orange", "black") },
            { "Flying", ("lightblue", "black") },
            { "Ghost", ("purple", "white") },
            { "Grass", ("green", "black") },
            { "Ground", ("brown", "white") },
            { "Ice", ("lightblue", "black") },
            { "Poison", ("purple", "white") },
            { "Psychic", ("pink", "black") },
            { "Rock", ("gray", "black") },
            { "Steel", ("silver", "black") },
            { "Water", ("blue", "white") },
            { "Normal", ("gray", "black") }
        };

        // Constructor to initialize the form with a name (used for Pokémon lookup)
        public PokemonInfo(string name)
        {
            InitializeComponent();
            // Disable custom styles for the progress bars
            ProgressBarExtensions.DisableStyle(progressBarHp);
            ProgressBarExtensions.DisableStyle(progressBarAtk);
            ProgressBarExtensions.DisableStyle(progressBarDef);
            ProgressBarExtensions.DisableStyle(progressBarSpAtk);
            ProgressBarExtensions.DisableStyle(progressBarSpDef);
            ProgressBarExtensions.DisableStyle(progressBarSpd);
            // Store the name or ID of the Pokémon
            this.nameId = name;
            // Load Pokémon information from the API
            LoadPokemonInfo();
            // Update button text
            UpdateButtonText();
        }

        // Constructor to initialize the form with an ID (used for Pokémon lookup)
        public PokemonInfo(int id)
        {
            InitializeComponent();
            // Disable custom styles for the progress bars
            ProgressBarExtensions.DisableStyle(progressBarHp);
            ProgressBarExtensions.DisableStyle(progressBarAtk);
            ProgressBarExtensions.DisableStyle(progressBarDef);
            ProgressBarExtensions.DisableStyle(progressBarSpAtk);
            ProgressBarExtensions.DisableStyle(progressBarSpDef);
            ProgressBarExtensions.DisableStyle(progressBarSpd);
            // Store the name or ID of the Pokémon
            this.nameId = id.ToString();
            // Load Pokémon information from the API
            LoadPokemonInfo();
            // Update button text
            UpdateButtonText();
        }

        // Event handler for the paint event of the table layout panel (not currently used)
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // This event handler is empty and not used currently.
        }

        // Event handler for when label1 is clicked (not currently used)
        private void label1_Click(object sender, EventArgs e)
        {
            // This event handler is empty and not used currently.
        }

        // Event handler for when the form is loaded (not currently used)
        private void PokemonInfo_Load(object sender, EventArgs e)
        {
            // This event handler is empty and not used currently.
        }

        // Method to make a synchronous HTTP request to the specified URL
        private string HttpRequest(string url)
        {
            // Create a new HttpClient instance
            HttpClient client = new HttpClient();
            // Send a GET request to the specified URL and block until the response is received
            HttpResponseMessage response = client.GetAsync(url).Result; // .Result makes the call synchronous
            // Return the response content as a string
            return response.Content.ReadAsStringAsync().Result;
        }

        // Method to load Pokémon information from the API and display it on the form
        private void LoadPokemonInfo()
        {
            // Build the URL to fetch the selected Pokémon data
            string url = $"{urlPokemon}{nameId.ToLower()}";

            // Make the HTTP request and get the response as a JSON string
            string response = HttpRequest(url);

            // Deserialize the JSON response to a Pokémon object
            pokemon = JsonSerializer.Deserialize<Pokemon>(response);

            // Display the fetched information in the UI
            DisplayPokemonInfo(pokemon);
        }

        // Method to display Pokémon information on the form
        private void DisplayPokemonInfo(Pokemon pokemon)
        {
            this.pokemon = pokemon;
            // Display the Pokémon's ID and name
            labelId.Text = $"#{pokemon.Id}";
            labelName.Text = ToTitleCase(pokemon.Name);
            Text = ToTitleCase(pokemon.Name);

            // Display the first Pokémon type if available
            if (pokemon.Types.Count > 0)
            {
                labelType.Text = ToTitleCase(pokemon.Types[0].typeInfo.Name);  // Display the first type
                labelType.Visible = true;  // Make sure the label is visible

                // Set the background and foreground colors based on the type
                if (pokemonTypeColors.TryGetValue(labelType.Text, out var colors))
                {
                    labelType.BackColor = System.Drawing.Color.FromName(colors.backColor);
                    labelType.ForeColor = System.Drawing.Color.FromName(colors.foreColor);
                    labelName.BackColor = System.Drawing.Color.FromName(colors.backColor);
                    labelName.ForeColor = System.Drawing.Color.FromName(colors.foreColor);
                }
                else
                {
                    labelType.BackColor = System.Drawing.Color.White; // Default background color
                    labelType.ForeColor = System.Drawing.Color.Black; // Default foreground color
                }

                // Display the second Pokémon type if available
                if (pokemon.Types.Count > 1)
                {
                    labelType2.Text = ToTitleCase(pokemon.Types[1].typeInfo.Name);  // Display the second type
                    labelType2.Visible = true;  // Make sure the second label is visible
                    if (pokemonTypeColors.TryGetValue(labelType2.Text, out var colors2))
                    {
                        labelType2.BackColor = System.Drawing.Color.FromName(colors2.backColor);
                        labelType2.ForeColor = System.Drawing.Color.FromName(colors2.foreColor);
                    }
                    else
                    {
                        labelType2.BackColor = System.Drawing.Color.White; // Default background color
                        labelType2.ForeColor = System.Drawing.Color.Black; // Default foreground color
                    }
                }
                else
                {
                    labelType2.Visible = false;  // Hide the second label if only one type exists
                }
            }

            // Display the Pokémon's stats on the form
            labelHp.Text = $"{pokemon.Stats[0].BaseStat}";
            labelAtk.Text = $"{pokemon.Stats[1].BaseStat}";
            labelDef.Text = $"{pokemon.Stats[2].BaseStat}";
            labelSpAtk.Text = $"{pokemon.Stats[3].BaseStat}";
            labelSpDef.Text = $"{pokemon.Stats[4].BaseStat}";
            labelSpd.Text = $"{pokemon.Stats[5].BaseStat}";

            // Update progress bars for each stat and change their color accordingly
            progressBarHp.Value = pokemon.Stats[0].BaseStat;
            UpdateProgressBarColor(progressBarHp);
            progressBarAtk.Value = pokemon.Stats[1].BaseStat;
            UpdateProgressBarColor(progressBarAtk);
            progressBarDef.Value = pokemon.Stats[2].BaseStat;
            UpdateProgressBarColor(progressBarDef);
            progressBarSpAtk.Value = pokemon.Stats[3].BaseStat;
            UpdateProgressBarColor(progressBarSpAtk);
            progressBarSpDef.Value = pokemon.Stats[4].BaseStat;
            UpdateProgressBarColor(progressBarSpDef);
            progressBarSpd.Value = pokemon.Stats[5].BaseStat;
            UpdateProgressBarColor(progressBarSpd);

            // Load the official Pokémon sprite (image) from the specified URL
            string artworkUrl = $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/{pokemon.Id}.png";
            pictureBox1.Load(artworkUrl);

            // Convert height from decimeters to meters and round to two decimal places
            double heightInM = Math.Round(pokemon.Height / 10.0, 2);  // 1 dm = 0.1 m
            double weightInKg = Math.Round(pokemon.Weight / 10.0, 2); // Convert weight from hectograms to kilograms

            // Update the height and weight labels
            labelHeight.Text = $"{heightInM} m";
            labelWeight.Text = $"{weightInKg} kg";
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
        public static string ToTitleCase(string str)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(str);
        }

        // Method to update the color of the progress bar based on its value
        private static void UpdateProgressBarColor(ProgressBar progressBar)
        {
            // Get the current percentage value of the progress bar
            double percentage = (double)progressBar.Value / progressBar.Maximum * 100;

            // Define the color ranges based on the percentage value divided into 6 parts
            if (percentage < 16.67)
            {
                progressBar.ForeColor = ColorTranslator.FromHtml("#f34444"); // Red
            }
            else if (percentage < 33.33)
            {
                progressBar.ForeColor = ColorTranslator.FromHtml("#ff7f0f"); // Orange
            }
            else if (percentage < 50)
            {
                progressBar.ForeColor = ColorTranslator.FromHtml("#ffdd57"); // Yellow
            }
            else if (percentage < 66.67)
            {
                progressBar.ForeColor = ColorTranslator.FromHtml("#a0e515"); // Light Green
            }
            else if (percentage < 83.33)
            {
                progressBar.ForeColor = ColorTranslator.FromHtml("#23cd5e"); // Green
            }
            else
            {
                progressBar.ForeColor = ColorTranslator.FromHtml("#00c2b8"); // Teal
            }
        }
        // Method to update the text on the navigation buttons (Previous and Next) to display the IDs of adjacent Pokémon
        private void UpdateButtonText()
        {
            // Set the text of the 'Next' button to show the ID of the next Pokémon
            buttonNext.Text = $"#{pokemon.Id + 1}";

            // Set the text of the 'Previous' button to show the ID of the previous Pokémon
            buttonPrevious.Text = $"#{pokemon.Id - 1}";
        }

        // Event handler for when the 'Previous' button is clicked
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            // Update the nameId to the ID of the previous Pokémon (decrement by 1)
            nameId = (pokemon.Id - 1).ToString();

            // Load information for the previous Pokémon and display it
            LoadPokemonInfo();

            // Update the navigation buttons with the new Pokémon IDs
            UpdateButtonText();
        }

        // Event handler for when the 'Next' button is clicked
        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Update the nameId to the ID of the next Pokémon (increment by 1)
            nameId = (pokemon.Id + 1).ToString();

            // Load information for the next Pokémon and display it
            LoadPokemonInfo();

            // Update the navigation buttons with the new Pokémon IDs
            UpdateButtonText();
        }
    }
}
