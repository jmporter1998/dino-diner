using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The steakosaurus burger class
    /// </summary>
    public class SteakosaurusBurger :Entree, IMenuItem
    {
        /// <summary>
        /// The bool represetning if the burger has a bun
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// The bool represetning if the burger has pickles
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// The bool represetning if the burger has ketchup
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// The bool represetning if the burger has mustard
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// The steakosaurus burger constructor
        /// </summary>
        public SteakosaurusBurger()
        {
            Price = 5.15;
            Calories = 621;
            ingredients.Add("Steakburger Pattie");
            if (bun) ingredients.Add("Whole Wheat Bun");
            if (pickle) ingredients.Add("Pickle");
            if (ketchup) ingredients.Add("Ketchup");
            if (mustard) ingredients.Add("Mustard");
        }

        /// <summary>
        /// Holds the bun
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            ingredients.Remove("Whole Wheat Bun");
        }

        /// <summary>
        /// Holds the pickle
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            ingredients.Remove("Pickle");
        }

        /// <summary>
        /// Holds the ketchup
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            ingredients.Remove("Ketchup");
        }

        /// <summary>
        /// Holds the mustard
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            ingredients.Remove("Mustard");
        }

        /// <summary>
        /// The to string method for the class
        /// </summary>
        /// <returns>The string representing the items name</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
