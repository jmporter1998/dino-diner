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

        /// <summary>
        /// The list of the possible sizes
        /// </summary>
        [BindProperty]
        public List<Size> possibleSizes
        {
            get
            {
                List<Size> result = new List<Size>();
                result.Add(Size.Small);
                result.Add(Size.Medium);
                result.Add(Size.Large);
                return result;
            }
        }


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

        private IEnumerable<IMenuItem> combos = new List<IMenuItem>();

        /// <summary>
        /// The lsit of the combos
        /// </summary>
        [BindProperty]
        public IEnumerable<IMenuItem> Combos
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

        private IEnumerable<IMenuItem> drinks = new List<IMenuItem>();

        /// <summary>
        /// The list of the drinks
        /// </summary>
        [BindProperty]
        public IEnumerable<IMenuItem> Drinks
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

        private IEnumerable<IMenuItem> entrees = new List<IMenuItem>();

        /// <summary>
        /// The lsit of the entrees
        /// </summary>
        [BindProperty]
        public IEnumerable<IMenuItem> Entrees
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


        private IEnumerable<IMenuItem> sides = new List<IMenuItem>();

        /// <summary>
        /// The list of the sides
        /// </summary>
        [BindProperty]
        public IEnumerable<IMenuItem> Sides
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
                Combos = Combos.Where(item => item.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
                Drinks = Drinks.Where(item => item.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
                Entrees = Entrees.Where(item => item.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
                Sides = Sides.Where(item => item.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            if (minimumPrice != null)
            {
                Combos = Combos.Where(item => item.Price >= minimumPrice);
                Drinks = Drinks.Where(item => item.Price >= minimumPrice);
                Entrees = Entrees.Where(item => item.Price >= minimumPrice);
                Sides = Sides.Where(item => item.Price >= minimumPrice);
            }

            if (maximumPrice != null)
            {
                Combos = Combos.Where(item => item.Price <= maximumPrice);
                Drinks = Drinks.Where(item => item.Price <= maximumPrice);
                Entrees = Entrees.Where(item => item.Price <= maximumPrice);
                Sides = Sides.Where(item => item.Price <= maximumPrice);
            }

            if(possibleIngredients.Count > 0)
            {
                foreach (string ingredients in possibleIngredients)
                {
                    Combos = Combos.Where(item => !(item.Ingredients.Contains(ingredients)));
                    Drinks = Drinks.Where(item => !(item.Ingredients.Contains(ingredients)));
                    Entrees = Entrees.Where(item => !(item.Ingredients.Contains(ingredients)));
                    Sides = Sides.Where(item => !(item.Ingredients.Contains(ingredients)));
                }
            }

            if (menuCategory.Count > 0)
            {
                
            }

        }
    }
}