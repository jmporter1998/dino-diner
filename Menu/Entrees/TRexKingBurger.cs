using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree, IMenuItem
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
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the pickle
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            ingredients.Remove("Pickle");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the ketchup
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            ingredients.Remove("Ketchup");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the mustard
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            ingredients.Remove("Mustard");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            ingredients.Remove("Lettuce");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the tomato
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
            ingredients.Remove("Tomato");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the onion
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            ingredients.Remove("Onion");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the mayo
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
            ingredients.Remove("Mayo");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// The to string method for the class
        /// </summary>
        /// <returns>The string representing the items name</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
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
                if (!bun) special.Add("Hold Whole Wheat Bun");
                if (!pickle) special.Add("Hold Pickes");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!tomato) special.Add("Hold Tomato");
                if (!onion) special.Add("Hold Onion");
                if (!mayo) special.Add("Hold Mayonnaise");
                return special.ToArray();
            }
        }

        /// <summary>
        /// An event handler for PropertyChanged events for peanut butter, jelly, description, and special
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
