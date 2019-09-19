using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The prehistoric pbj class
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// The bool for if the sandwich contains pennut butter
        /// </summary>
        private bool peanutButter = true;

        /// <summary>
        /// The bool for if the sandwich contains jelly
        /// </summary>
        private bool jelly = true;
        
        /// <summary>
        /// The constructor for the prehistoric pbj
        /// </summary>
        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
            ingredients.Add("Bread");
            if (peanutButter) ingredients.Add("Peanut Butter");
            if (jelly) ingredients.Add("Jelly");
        }

        /// <summary>
        /// Removes pennut butter from the sandwich
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            ingredients.Remove("Peanut Butter");
        }

        /// <summary>
        /// Removes jelly from the sandwich
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            ingredients.Remove("Jelly");
        }
    }
}
