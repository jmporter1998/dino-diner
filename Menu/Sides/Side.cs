﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    

    /// <summary>
    /// The abstract class for sides
    /// </summary>
    public abstract class Side : IOrderItem
    {

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The property changed event 
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


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

        /// <summary>
        /// gets the special for the side
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// gets the  description for the side
        /// </summary>
        public abstract string Description { get; }

    }
}
