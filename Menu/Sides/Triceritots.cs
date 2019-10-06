using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// The Triceritots class
    /// </summary>
    public class Triceritots : Side, IMenuItem
    {
        private Size size;

        /// <summary>
        /// Sets the size for the Triceritots 
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
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
            }
            get { return size; }
        }
            
        
        /// <summary>
        /// The constructor for the triceritot class
        /// </summary>
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;
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
            return $"{Size} Triceritots";
        }

    }
}
