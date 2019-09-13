using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

        
        public List<string> Ingredients { get; set; }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
            this.Ingredients = new List<string>();
            for (int i = 0; i < 6; i++)
            {
                Ingredients.Add("Chicken Nugget");
            }
        }

        public void AddNugget()
        {
            Ingredients.Add("Chicken Nugget");
            this.Price += 0.25;
            this.Calories += 59;
            
        }
    }
}
