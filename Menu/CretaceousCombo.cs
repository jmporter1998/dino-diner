using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class CretaceousCombo :IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        protected Entree entree;

        public Entree Entree
        {
            get { return entree; }
            protected set
            {
                entree = value;
            }

        }

        private Side side;
        public Side Side
        {
            get { return side; }
            set
            {
                side = value;
                side.Size = size;
            }
        }

        private Drink drink = new Sodasaurus();


        public Drink Drink
        {
            get { return drink; }
            set
            {
                drink = value;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Drink");

            }
        }

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

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");

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

    public override string ToString()
    {
        return $"{Entree} Combo";
    }

    public string[] Special
    {
        get
        {
            List<string> special = new List<string>();
            special.AddRange(Entree.Special);
            special.Add(Side.Description);
            special.AddRange(Side.Special);
            special.Add(Drink.Description);
            special.AddRange(Drink.Special);
            return special.ToArray();
        }
    }

    public string Description
    {
        get
        {
                return this.ToString();
        }
    }
}
}
