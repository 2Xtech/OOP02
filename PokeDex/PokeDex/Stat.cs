using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex
{
    // Class representing a Pokémon's stat, such as HP, Attack, Defense, etc.
    public class Stat
    {
        // Property to hold the detailed information about the stat (e.g., name)
        [JsonPropertyName("stat")]
        public StatInfo StatInfo { get; set; }

        // Property to hold the base value of the stat (e.g., the base HP or base Attack value)
        [JsonPropertyName("base_stat")]
        public int BaseStat { get; set; }
    }

    // Class representing detailed information about the stat, like its name
    public class StatInfo
    {
        // Property to hold the name of the stat (e.g., "hp", "attack", "defense")
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

}
