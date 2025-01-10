using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex
{
    // Class representing a Pokémon with properties for its ID, name, physical attributes, types, and stats
    public class Pokemon
    {
        // Property to hold the Pokémon's ID (e.g., 1 for Bulbasaur)
        [JsonInclude]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        // Property to hold the name of the Pokémon (e.g., "Bulbasaur")
        [JsonInclude]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        // Property to hold the height of the Pokémon in decimeters (e.g., 7 for Bulbasaur)
        [JsonPropertyName("height")]
        public int Height { get; set; }

        // Property to hold the weight of the Pokémon in hectograms (e.g., 69 for Bulbasaur)
        [JsonPropertyName("weight")]
        public int Weight { get; set; }

        // Property to hold a list of types that the Pokémon has (e.g., "Grass" and "Poison")
        [JsonPropertyName("types")]
        public List<PokemonType> Types { get; set; }

        // Property to hold a list of stats for the Pokémon, such as HP, Attack, Defense, etc.
        [JsonPropertyName("stats")]
        public List<Stat> Stats { get; set; }
    }

}
