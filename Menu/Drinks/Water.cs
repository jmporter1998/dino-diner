using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink, IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The field that shows if the water should have a lemon
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// The constructor for water
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            Ingredients.Add("Water");
        }

        /// <summary>
        /// Adds a lemon to the water
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            Ingredients.Add("Lemon");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// The to string method for the class
        /// </summary>
        /// <returns>The string representing the items name</returns>
        public override string ToString()
        {
            return $"{Size} Water";            
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
                if (!Ice) special.Add("Hold Ice");
                if (Lemon) special.Add("Add Lemon");
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
