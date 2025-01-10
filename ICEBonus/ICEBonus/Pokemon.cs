using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ICEBonus
{
    public class Pokemon
    {
        [JsonInclude]
        public int id;

        [JsonInclude]
        public string name;

        [JsonInclude]
        public Sprites sprites;
    }
    public class Sprites
    {
        [JsonInclude]
        [JsonPropertyName("front_default")]
        public string frontDefault;
    }
}
