﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The velociwrap class
    /// </summary>
    public class VelociWrap : Entree
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
        }

        /// <summary>
        /// Holds the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            ingredients.Remove("Lettuce");
        }

        /// <summary>
        /// Holds the cheese
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
            ingredients.Remove("Parmesan Cheese");
        }
    }
}
