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
using DDSize = DinoDiner.Menu.Size;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {

        Drink drink;
         
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The click event for the Sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectSodasaurus(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                order.Add(drink);
                uxFlavor.IsEnabled = true;
            }
        }

        /// <summary>
        /// The click event for the Jurrasic Java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectJurrasicJava(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new JurrasicJava();
                order.Add(drink);
                uxDecaf.IsEnabled = true;

            }
        }

        /// <summary>
        /// The click event for the tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTyrannotea(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                order.Add(drink);
                uxSweet.IsEnabled = true;
                uxAddLemon.IsEnabled = true;

            }
        }


        /// <summary>
        /// The click event for the tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectWater(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Water();
                order.Add(drink);
                uxAddLemon.IsEnabled = true;
            }
        }


        /// <summary>
        /// The click event to change the size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }

        /// <summary>
        /// THe click event for the done button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// The click event for the flavor button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnSelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        /// <summary>
        /// The click event for the add lemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnSelectAddLemon(object sender, RoutedEventArgs args)
        {
           if (drink is Water water)
            {
                water.AddLemon();
            }
            if (drink is Tyrannotea tyrannotea)
            {
                tyrannotea.AddLemon();
            }
        }


        /// <summary>
        /// The click event for the sweet button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnSelectSweet(object sender, RoutedEventArgs args)
        {
            if (drink is Tyrannotea tyrannotea)
            {
                tyrannotea.Sweet = true;
            }
        }

        /// <summary>
        /// The click event for decaf button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnSelectDecaf(object sender, RoutedEventArgs args)
        {
            if (drink is JurrasicJava jurrasicJava)
            {
                jurrasicJava.Decaf = true;
            }
        }



        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
        }
    }
}
