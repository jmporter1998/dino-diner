using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        private TRexKingBurger burger;

        public CustomizeTRexKingBurger(TRexKingBurger burger)
        {
            InitializeComponent();
            this.burger = burger;
        }
        

        /// <summary>
        /// The hold bun click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            this.burger.HoldBun();
        }

        /// <summary>
        /// The hold pickle click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            this.burger.HoldPickle();
        }

        /// <summary>
        /// The hold ketchup event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            this.burger.HoldKetchup();
        }

        /// <summary>
        /// The hold mustard click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            this.burger.HoldMustard();
        }

        /// <summary>
        /// The click event for the done button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }

        /// <summary>
        /// THe hold mayo click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldMayo(object sender, RoutedEventArgs e)
        {
            this.burger.HoldMayo();
        }

        /// <summary>
        /// The hold onion click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs e)
        {
            this.burger.HoldOnion();
        }

        /// <summary>
        /// The hold lettuce click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {
            this.burger.HoldLettuce();
        }

        /// <summary>
        /// The hold tomato click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldTomato(object sender, RoutedEventArgs e)
        {
            this.burger.HoldTomato();
        }
    }
}
