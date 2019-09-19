using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger : Entree
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
        /// The bool represetning if the burger has lettuce
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// The bool represetning if the burger has tomato
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// The bool represetning if the burger has onion
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// The bool represetning if the burger has mayo
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// The constructor for the t rex king burger
        /// </summary>
        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            if (bun) ingredients.Add("Whole Wheat Bun");
            if (pickle) ingredients.Add("Pickle");
            if (ketchup) ingredients.Add("Ketchup");
            if (mustard) ingredients.Add("Mustard");
            if (lettuce) ingredients.Add("Lettuce");
            if (tomato) ingredients.Add("Tomato");
            if (onion) ingredients.Add("Onion");
            if (mayo) ingredients.Add("Mayo");
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
        /// Holds the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            ingredients.Remove("Lettuce");
        }

        /// <summary>
        /// Holds the tomato
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
            ingredients.Remove("Tomato");
        }

        /// <summary>
        /// Holds the onion
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            ingredients.Remove("Onion");
        }

        /// <summary>
        /// Holds the mayo
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
            ingredients.Remove("Mayo");
        }
    }
}
