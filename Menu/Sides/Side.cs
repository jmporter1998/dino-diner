﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// The enumerator for the side's three sizes (small, medium, large)
    /// </summary>
    public enum Size
    {
        Small,
        Medium, 
        Large
    }

    /// <summary>
    /// The abstract class for sides
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// The ingredients list for the side
        /// </summary>
        protected List<string> ingredients = new List<string>();
        
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients { get { return ingredients; } }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

    }
}
