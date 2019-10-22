using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class JurrasicJava : Drink , IMenuItem, INotifyPropertyChanged
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
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
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
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Adds ice to the jurrasic java
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// The to string method for the class
        /// </summary>
        /// <returns>The string representing the items name</returns>
        public override string ToString()
        {
            if (Decaf) return $"{size} Decaf Jurassic Java";
            return $"{size} Jurassic Java";
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
                if (RoomForCream) special.Add("Leave Room For Cream");
                if (Ice) special.Add("Add Ice");
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
