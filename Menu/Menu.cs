/* Menu Class
 * Author: Joshua Porter
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the Menu for the Dino Diner.
    /// </summary>
    public class Menu
    {
        
        /// <summary>
        /// Returns a list of menu items.
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> menuItems = new List<IMenuItem>();
                menuItems.Add(new Brontowurst());
                menuItems.Add(new DinoNuggets());
                menuItems.Add(new PrehistoricPBJ());
                menuItems.Add(new PterodactylWings());
                menuItems.Add(new SteakosaurusBurger());
                menuItems.Add(new TRexKingBurger());
                menuItems.Add(new VelociWrap());
                menuItems.Add(new Fryceritops());
                menuItems.Add(new MeteorMacAndCheese());
                menuItems.Add(new MezzorellaSticks());
                menuItems.Add(new Triceritots());
                menuItems.Add(new JurrasicJava());
                menuItems.Add(new Sodasaurus());
                menuItems.Add(new Tyrannotea());
                menuItems.Add(new Water());
                return menuItems;
            }
        }

        /// <summary>
        /// Returns the list of entrees.
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> entrees = new List<IMenuItem>();
                entrees.Add(new Brontowurst());
                entrees.Add(new DinoNuggets());
                entrees.Add(new PrehistoricPBJ());
                entrees.Add(new PterodactylWings());
                entrees.Add(new SteakosaurusBurger());
                entrees.Add(new TRexKingBurger());
                entrees.Add(new VelociWrap());
                return entrees;
            }
        }

        /// <summary>
        /// Returns the list of sides.
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> sides = new List<IMenuItem>();
                sides.Add(new Fryceritops());
                sides.Add(new MeteorMacAndCheese());
                sides.Add(new MezzorellaSticks());
                sides.Add(new Triceritots());
                return sides;
            }
        }

        /// <summary>
        /// Returns the list of drinks.
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> drinks = new List<IMenuItem>();
                drinks.Add(new JurrasicJava());
                drinks.Add(new Sodasaurus());
                drinks.Add(new Tyrannotea());
                drinks.Add(new Water());
                return drinks;
            }
            
        }

        
        /// <summary>
        /// Returns the lsit of combos.
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> combos = new List<IMenuItem>();
                combos.Add(new CretaceousCombo(new Brontowurst()));
                combos.Add(new CretaceousCombo(new DinoNuggets()));
                combos.Add(new CretaceousCombo(new PrehistoricPBJ()));
                combos.Add(new CretaceousCombo(new PterodactylWings()));
                combos.Add(new CretaceousCombo(new SteakosaurusBurger()));
                combos.Add(new CretaceousCombo(new TRexKingBurger()));
                combos.Add(new CretaceousCombo(new VelociWrap()));
                return combos;
            }
            
        }

        /// <summary>
        /// Returns all of the possible ingredients
        /// </summary>
        public List<string> PossibleIngredients
        {
            get
            {
                HashSet<string> result = new HashSet<string>();
                Menu menu = new Menu();
                foreach (IMenuItem item in menu.AvailableMenuItems)
                {
                    foreach (string ingredient in item.Ingredients)
                    {
                        result.Add(ingredient);
                    }
                }
                return result.ToList();
            }
        }

        /// <summary>
        /// Overrides the ToString().
        /// </summary>
        /// <returns>The full menu contents.</returns>
        public override string ToString()
        {
            StringBuilder menu = new StringBuilder();
            menu.Append("Dino Diner Menu\n");
            menu.Append("Combos:\n");
            foreach (List<IMenuItem> items in AvailableCombos)
            {
                menu.Append($"{items}\n");
            }
            menu.Append("Entrees:\n");
            foreach (List<IMenuItem> items in AvailableEntrees)
            {
                menu.Append($"{items}\n");
            }
            menu.Append("Sides:\n");
            foreach (List<IMenuItem> items in AvailableSides)
            {
                menu.Append($"{items}\n");
            }
            menu.Append("Drinks:\n");
            foreach (List<IMenuItem> items in AvailableDrinks)
            {
                menu.Append($"{items}\n");
            }
            return menu.ToString();
        }
    }
}