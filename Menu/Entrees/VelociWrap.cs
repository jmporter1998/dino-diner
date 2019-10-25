using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The velociwrap class
    /// </summary>
    public class VelociWrap : Entree, IMenuItem
    {
        /// <summary>
        /// The bool represetning if it has dressing
        /// </summary>
        private bool dressing = true;

        /// <summary>
        /// The bool represetning if it has lettuce
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// The bool represetning if it has cheese
        /// </summary>
        private bool cheese = true;
        
        /// <summary>
        /// The constructor for the velociwrap class
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
            ingredients.Add("Flour Tortilla");
            ingredients.Add("Chicken Breast");
            if (dressing) ingredients.Add("Ceasar Dressing");
            if (lettuce) ingredients.Add("Romaine Lettuce");
            if (cheese) ingredients.Add("Parmesan Cheese");
        }

        /// <summary>
        /// Holds the dressing
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
            ingredients.Remove("Dressing");
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
        /// Holds the cheese
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
            ingredients.Remove("Parmesan Cheese");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// The to string method for the class
        /// </summary>
        /// <returns>The string representing the items name</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
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
                if (!dressing) special.Add("Hold Dressing");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!cheese) special.Add("Hold Cheese");
                return special.ToArray();
            }
        }

        
    }
}
