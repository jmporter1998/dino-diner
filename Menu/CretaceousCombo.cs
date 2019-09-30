using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;

namespace DinoDiner.Menu
{
    class CretaceousCombo
    {
        public Entree Entree { get; set; }

        private Side side;
        public Side Side
        {
            get { return side; }
            set {
                side = value;
                side.Size = size;
            }
        }
        public Drink Drink { get; set; }

        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
            
        }

        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        private Size size = Size.Small;

        public Size Size
        {
            get {return size;}
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        } 

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredeints = new List<string>();
                ingredeints.AddRange(Entree.Ingredients);
                ingredeints.AddRange(Side.Ingredients);
                ingredeints.AddRange(Drink.Ingredients);
                return ingredeints;
            }
        }

        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }
    }
}
