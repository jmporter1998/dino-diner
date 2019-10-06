using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink, IMenuItem
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
            set {
                if(!Sweet && value == true)
                {
                    Calories = Calories * 2;
                    Ingredients.Add("Cane Sugar");
                    sweet = value;
                }
                else if(Sweet && value == false)
                {
                    Calories = Calories / 2;
                    Ingredients.Remove("Cane Sugar");
                    sweet = value;
                }
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
    }
}
