using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// The private backing field
        /// </summary>
        private Size size;

        /// <summary>
        /// Shows if the JurrasicJava should have room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Shows if the jurrasicJava is decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Changes the size and coresponding values
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                if (size == Size.Small)
                {
                    Price = 0.59;
                    Calories = 2;
                }
                else if (size == Size.Medium)
                {
                    Price = 0.99;
                    Calories = 4;
                }
                else if (size == Size.Large)
                {
                    Price = 1.49;
                    Calories = 8;
                }
            }
        }

        /// <summary>
        /// The constructor for jurrasicjava
        /// </summary>
        public JurrasicJava()
        {
            Ice = false;
            Size = Size.Small;
            Ingredients.Add("Water");
            Ingredients.Add("Coffee");
        }

        /// <summary>
        /// Leaves room for cream
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        /// <summary>
        /// Adds ice to the jurrasic java
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }
    }
}
