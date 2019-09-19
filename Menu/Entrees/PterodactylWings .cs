using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The Pterodactyl Wings class
    /// </summary>
    public class PterodactylWings : Entree
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
    }
}
