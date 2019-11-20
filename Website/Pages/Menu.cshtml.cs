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
        //Private backing variable
        private Menu menu = new Menu();

        /// <summary>
        /// Property to return the menu.
        /// </summary>
        public Menu Menu
        {
            get
            {
                return menu;
            }
        }

        /// <summary>
        /// The on get event handler
        /// </summary>
        public void OnGet()
        {

        }
    }
}