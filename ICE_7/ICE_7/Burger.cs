using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_7
{
    //Burger class
    // Has Burger name and price
    public class Burger
    {
        //private variables
        private string name;
        private double price;

        /// <summary>
        /// Constructor - Creates a new Burger object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Burger(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        // To get the name of the burger
        public string GetName()
        {
            return name;
        }

        // To get the price of the burger
        public double GetPrice()
        {
            return price;
        }
    }
}
