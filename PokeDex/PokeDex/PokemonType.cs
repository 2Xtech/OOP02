using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex
{
    public class PokemonType
    {
        // Property to hold the type information of the Pokémon, deserialized from the "type" JSON field
        [JsonPropertyName("type")]
        public TypeInfo typeInfo { get; set; } // Contains detailed information about the Pokémon's type
    }

    public class TypeInfo
    {
        // Property to hold the name of the type, deserialized from the "name" JSON field
        [JsonPropertyName("name")]
        public string Name { get; set; } // The name of the Pokémon type (e.g., "Fire", "Water")
    }

}
