using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ICEBonus
{
    public class AllPokemon
    {
        [JsonInclude]
        public int count;

        [JsonInclude]
        [JsonPropertyName("results")]
        public Pokemon[] pokeArray;
    }
}
