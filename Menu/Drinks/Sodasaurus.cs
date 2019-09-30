using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// The private backing field
        /// </summary>
        private Size size;

        /// <summary>
        /// The private backing field
        /// </summary>
        private SodasaurusFlavor flavor;

        /// <summary>
        /// Gets and sets the flavor
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        /// <summary>
        /// Changes the size and coresponding values
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set {
                size = value;
                if(size == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                }
                else if (size == Size.Medium)
                {
                    Price = 2.00;
                    Calories = 156;
                }
                else if (size == Size.Large)
                {
                    Price = 2.50;
                    Calories = 208;
                }
            }
        }

        /// <summary>
        /// The constructor for sodasaurus
        /// </summary>
        public Sodasaurus()
        {
            Size = Size.Small;
            Ingredients.Add("Water");
            Ingredients.Add("Natural Flavors");
            Ingredients.Add("Cane Sugar");
        }
    }
}
