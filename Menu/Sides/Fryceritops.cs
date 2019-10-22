using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The fryceritops class
    /// </summary>
    public class Fryceritops : Side, IMenuItem
    {
        private Size size;

        /// <summary>
        /// Sets the size for the fryceritops 
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
            }
            get { return size; }
            
        }


        /// <summary>
        /// The constructor for the fryceritops class
        /// </summary>
        public Fryceritops()
        {
            Price = 0.99;
            Calories = 222;
            ingredients.Add("Potato");
            ingredients.Add("Salt");
            ingredients.Add("Vegetable Oil");
        }

        /// <summary>
        /// The to string method for the class
        /// </summary>
        /// <returns>The string representing the items name</returns>
        public override string ToString()
        {
            return $"{Size} Fryceritops";
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
