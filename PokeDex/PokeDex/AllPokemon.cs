using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex
{
    public class AllPokemon
    {
        // Property to hold the list of Pokémon, deserialized from the "results" JSON field
        [JsonInclude]
        [JsonPropertyName("results")]
        public List<Pokemon1> pokeArray { get; set; } // List of Pokémon objects
    }

    public class Pokemon1
    {
        // Property to hold the name of the Pokémon, deserialized from the "name" JSON field
        [JsonPropertyName("name")]
        public string Name { get; set; }

        // Property to hold the URL associated with the Pokémon, deserialized from the "url" JSON field
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

}
