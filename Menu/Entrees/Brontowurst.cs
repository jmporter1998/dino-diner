using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The brontowurst class
    /// </summary>
    public class Brontowurst : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
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
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the peppers
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            ingredients.Remove("Peppers");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the onions
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            ingredients.Remove("Onion");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// The to string method for the class
        /// </summary>
        /// <returns>The string representing the items name</returns>
        public override string ToString()
        {
            return "Brontowurst";
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
                if (!peppers) special.Add("Hold Peppers");
                if (!onions) special.Add("Hold Onions");
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
