using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        /// <summary>
        /// The field that shows if the water should have a lemon
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// The constructor for water
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            Ingredients.Add("Water");
        }

        /// <summary>
        /// Adds a lemon to the water
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            Ingredients.Add("Lemon");
        }
    }
}
