using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink, IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The private backing field
        /// </summary>
        private Size size;
        
        /// <summary>
        /// Backing field
        /// </summary>
        private bool sweet = false;

        /// <summary>
        /// The property that shows if the Tyrannotea is sweet
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set
            {
                if (!Sweet && value == true)
                {
                    Calories = Calories * 2;
                    Ingredients.Add("Cane Sugar");
                    sweet = value;
                }
                else if (Sweet && value == false)
                {
                    Calories = Calories / 2;
                    Ingredients.Remove("Cane Sugar");
                    sweet = value;
                }
                NotifyOfPropertyChanged("Description");
            }
        }
            




        /// <summary>
        /// The property that shows if the Tyrannotea has lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Gets and sets the size and coresponding values
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                if (size == Size.Small)
                {
                    Price = 0.99;
                    if (Sweet)
                    {
                        Calories = 16;
                    }
                    else
                    {
                        Calories = 8;
                    }
                }
                else if (size == Size.Medium)
                {
                    Price = 1.49;
                    if (Sweet)
                    {
                        Calories = 32;
                    }
                    else
                    {
                        Calories = 16;
                    }
                }
                else if (size == Size.Large)
                {
                    Price = 1.99;
                    if (Sweet)
                    {
                        Calories = 64;
                    }
                    else
                    {
                        Calories = 32;
                    }
                }
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
            }

        }

        /// <summary>
        /// The constructor for tyrannotea
        /// </summary>
        public Tyrannotea()
        {
            Size = Size.Small;
            Ingredients.Add("Water");
            Ingredients.Add("Tea");
        }

        /// <summary>
        /// Adds a lemon to the tyrannotea
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
            if (Sweet)
            {
                return $"{size} Sweet Tyrannotea";
            }
            else
            {
                return $"{size} Tyrannotea";
            }
            
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
