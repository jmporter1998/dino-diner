using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The brontowurst class
    /// </summary>
    public class Brontowurst : Entree
    {
        /// <summary>
        /// Bool showing if there should be a bun
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Bool showing if there should be peppers
        /// </summary>
        private bool peppers = true;

        /// <summary>
        /// Bool showing if there should be onions
        /// </summary>
        private bool onions = true;

        /// <summary>
        /// The constructor for the brontowurst menu item
        /// </summary>
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
            ingredients.Add("Brautwurst");
            if (bun) ingredients.Add("Whole Wheat Bun");
            if (peppers) ingredients.Add("Peppers");
            if (onions) ingredients.Add("Onion");
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
        /// Holds the peppers
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            ingredients.Remove("Peppers");
        }

        /// <summary>
        /// Holds the onions
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            ingredients.Remove("Onion");
        }
    }
}
