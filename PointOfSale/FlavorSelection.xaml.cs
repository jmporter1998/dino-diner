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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        public FlavorSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The button click for the cherry button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectCherry(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                int last = order.Items.Length-1;
                if (order.Items[last] is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.Cherry;
                    NavigationService.Navigate(new DrinkSelection(sodasaurus));
                }
                
            }
        }


        /// <summary>
        /// The button click for the chocolate button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectChocolate(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                int last = order.Items.Length - 1;
                if (order.Items[last] is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.Chocolate;
                    NavigationService.Navigate(new DrinkSelection(sodasaurus));
                }
            }
        }


        /// <summary>
        /// The button click for the cola button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectCola(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                int last = order.Items.Length - 1;
                if (order.Items[last] is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.Cola;
                    NavigationService.Navigate(new DrinkSelection(sodasaurus));
                }
            }
        }

        /// <summary>
        /// The button click for the lime button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectLime(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                int last = order.Items.Length - 1;
                if (order.Items[last] is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.Lime;
                    NavigationService.Navigate(new DrinkSelection(sodasaurus));
                }
            }
        }


        /// <summary>
        /// The button click for the orange button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectOrange(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                int last = order.Items.Length - 1;
                if (order.Items[last] is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.Orange;
                    NavigationService.Navigate(new DrinkSelection(sodasaurus));
                }
            }
        }


        /// <summary>
        /// The button click for the root beer button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectRootBeer(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                int last = order.Items.Length - 1;
                if (order.Items[last] is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.RootBeer;
                    NavigationService.Navigate(new DrinkSelection(sodasaurus));
                }
            }
        }


        /// <summary>
        /// The button click for the vanilla button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectVanilla(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                int last = order.Items.Length - 1;
                if (order.Items[last] is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = SodasaurusFlavor.Vanilla;
                    NavigationService.Navigate(new DrinkSelection(sodasaurus));
                }
            }
        }
    }
}
