﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Drink : IOrderItem
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
        /// protected backing field for Ingredients
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
        /// Gets and sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets and sets if the drink has ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Holds the ice from the drink
        /// </summary>
        public virtual void HoldIce()
        {
            Ice = false;
        }

        /// <summary>
        /// gets the special for the drink
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// gets the  description for the drink
        /// </summary>
        public abstract string Description { get; }
    }
}
