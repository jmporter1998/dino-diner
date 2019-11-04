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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        private Brontowurst brontowurst;


        /// <summary>
        /// The constructor fot jsut the entree
        /// </summary>
        /// <param name="brontowurst"></param>
        public CustomizeBrontowurst(Brontowurst brontowurst)
        {
            InitializeComponent();
            this.brontowurst = brontowurst;
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
        /// The click event for the hold bun button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            this.brontowurst.HoldBun();
        }


        /// <summary>
        /// The click event for the hold onions button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldOnions(object sender, RoutedEventArgs e)
        {
            this.brontowurst.HoldOnion();
        }

        /// <summary>
        /// The click  event for the hold peppers button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPeppers(object sender, RoutedEventArgs e)
        {
            this.brontowurst.HoldPeppers();
        }
    }
}
