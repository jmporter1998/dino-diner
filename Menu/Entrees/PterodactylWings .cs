using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The Pterodactyl Wings class
    /// </summary>
    public class PterodactylWings : Entree, IMenuItem
    {
        /// <summary>
        /// The constructor for pterodactyl wings
        /// </summary>
        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
            ingredients.Add("Chicken");
            ingredients.Add("Wing Sauce");
        }

        /// <summary>
        /// The to string method for the class
        /// </summary>
        /// <returns>The string representing the items name</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }

        /// <summary>
        /// Gets description of order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Returns the array of strings containong specials for the item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }
    }
}
