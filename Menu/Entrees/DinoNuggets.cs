using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The dino nugget class
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        private int count = 6;

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
            count++;
            Ingredients.Add("Chicken Nugget");
            this.Price += 0.25;
            this.Calories += 59;
            NotifyOfPropertyChanged("Special");

        }

        /// <summary>
        /// The to string method for the class
        /// </summary>
        /// <returns>The string representing the items name</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
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
                if (count>6) special.Add(count - 6 + " Extra Nuggets");
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
