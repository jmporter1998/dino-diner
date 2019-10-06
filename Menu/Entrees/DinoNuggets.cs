using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The dino nugget class
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem
    {
        /// <summary>
        /// The constructor for dino nuggets
        /// </summary>
        public DinoNuggets()
        {
            Price = 4.25;
            Calories = 354;
            for (int i = 0; i < 6; i++)
            {
                Ingredients.Add("Chicken Nugget");
            }
        }

        /// <summary>
        /// Adds a chicken nugget to the entree
        /// </summary>
        public void AddNugget()
        {
            Ingredients.Add("Chicken Nugget");
            this.Price += 0.25;
            this.Calories += 59;
            
        }

        /// <summary>
        /// The to string method for the class
        /// </summary>
        /// <returns>The string representing the items name</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
