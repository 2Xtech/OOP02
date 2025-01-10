using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ICE_9
{
    public class Victim
    {
        [JsonInclude]
        public bool isAlive;

        [JsonInclude]
        public string name;

        /// <summary>
        /// Creates a new victim object
        /// Victim starts alive
        /// </summary>
        /// <param name="name">Name of the victim</param>
        public Victim(string name)
        {
            this.name = name;
            isAlive = true;
        }
    }
}
