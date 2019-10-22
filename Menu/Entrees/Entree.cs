using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{

    public abstract class Entree : IOrderItem
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
        /// gets the special for the entree
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// gets the  description for the entree
        /// </summary>
        public abstract string Description { get; }


    }
}
