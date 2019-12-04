using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;


namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// THe binding property for the minimum price
        /// </summary>
        [BindProperty]
        public float? minimumPrice { get; set; }

        /// <summary>
        /// The binding property for the maximum price
        /// </summary>
        [BindProperty]
        public float? maximumPrice { get; set; }

        /// <summary>
        /// The binding property for the menu category
        /// </summary>
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        /// <summary>
        /// The list of the possible ingredients
        /// </summary>
        [BindProperty]
        public List<string> possibleIngredients { get; set; } = new List<string>();


        //Private backing variable
        private Menu menu = new Menu();

        /// <summary>
        /// Property to return the menu.
        /// </summary>
        public  Menu Menu
        {
            get
            {
                return menu;
            }
            set
            {
                menu = value;
            }
            
        }

        private List<IMenuItem> combos = new List<IMenuItem>();

        /// <summary>
        /// The lsit of the combos
        /// </summary>
        [BindProperty]
        public List<IMenuItem> Combos
        {
            get
            {
                return combos;
            }
            set
            {
                combos = value;
            }
        }

        private List<IMenuItem> drinks = new List<IMenuItem>();

        /// <summary>
        /// The list of the drinks
        /// </summary>
        [BindProperty]
        public List<IMenuItem> Drinks
        {
            get
            {
                return drinks;
            }
            set 
            {
                drinks = value;
            }
        }

        private List<IMenuItem> entrees = new List<IMenuItem>();

        /// <summary>
        /// The lsit of the entrees
        /// </summary>
        [BindProperty]
        public List<IMenuItem> Entrees
        {
            get
            {
                return entrees;
            }
            set 
            {
                entrees = value;
            }
        }


        private List<IMenuItem> sides = new List<IMenuItem>();

        /// <summary>
        /// The list of the sides
        /// </summary>
        [BindProperty]
        public List<IMenuItem> Sides
        {
            get
            {
                return sides;
            }
            set 
            {
                sides = value;
            }
        }


        /// <summary>
        /// The on get event handler
        /// </summary>
        public void OnGet()
        {
            Combos = Menu.AvailableCombos;
            Drinks = Menu.AvailableDrinks;
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;
        }

        /// <summary>
        /// The property that holds the search string
        /// </summary>
        [BindProperty]
        public string search { get; set; }

        /// <summary>
        /// The on post event
        /// </summary>
        public void OnPost()
        {

            Combos = Menu.AvailableCombos;
            Drinks = Menu.AvailableDrinks;
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;


            if (search != null)
            {
                Combos = Search(Combos);
                Drinks = Search(Drinks);
                Entrees = Search(Entrees);
                Sides = Search(Sides);
            }

            if (minimumPrice != null)
            {
                Combos = FilterByMinPrice(Combos);
                Drinks = FilterByMinPrice(Drinks);
                Entrees = FilterByMinPrice(Entrees);
                Sides = FilterByMinPrice(Sides);
            }

            if (maximumPrice != null)
            {
                Combos = FilterByMaxPrice(Combos);
                Drinks = FilterByMaxPrice(Drinks);
                Entrees = FilterByMaxPrice(Entrees);
                Sides = FilterByMaxPrice(Sides);
            }

            if (possibleIngredients.Count > 0)
            {
                Combos = FilterByIngredients(Combos);
                Drinks = FilterByIngredients(Drinks);
                Entrees = FilterByIngredients(Entrees);
                Sides = FilterByIngredients(Sides);
            }
            
            
        }

        /// <summary>
        /// Filters the menu by the word in the search bar
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public List<IMenuItem> Search(List<IMenuItem> list)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach (IMenuItem item in list)
            {
                if (item.ToString().Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        /// <summary>
        /// Filters the menu by the minimum price
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByMinPrice(List<IMenuItem> list)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach (IMenuItem item in list)
            {
                if (item.Price >= minimumPrice)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        /// <summary>
        /// Filters the menu by the max price
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByMaxPrice(List<IMenuItem> list)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach (IMenuItem item in list)
            {
                if (item.Price <= maximumPrice)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        /// <summary>
        /// filters the menu by ingredients
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByIngredients(List<IMenuItem> list)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach (IMenuItem item in list)
            {
                foreach (string ingredients in possibleIngredients)
                {
                    if (!item.Ingredients.Contains(ingredients))
                    {
                        result.Add(item);
                    }
                }
            }
            return result;
        }


    }
}