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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        private VelociWrap wrap;

        public CustomizeVelociWrap(VelociWrap wrap)
        {
            InitializeComponent();
            this.wrap = wrap;
        }

        /// <summary>
        /// THe hold dressing click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldDressing(object sender, RoutedEventArgs e)
        {
            wrap.HoldDressing();
        }

        /// <summary>
        /// The hold lettuce click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {
            wrap.HoldLettuce();
        }

        /// <summary>
        /// The hold cheese event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldCheese(object sender, RoutedEventArgs e)
        {
            this.wrap.HoldCheese();
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
    }
}
