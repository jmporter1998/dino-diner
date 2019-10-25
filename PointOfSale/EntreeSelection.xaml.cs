﻿using System;
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        Entree entree;

        public EntreeSelection()
        {
            InitializeComponent();
        }

        void SelectEntree(object sender, RoutedEventArgs args)
        {
        }

        /// <summary>
        /// The click event for the brontowurst
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// The click event for the dino nuggets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new DinoNuggets();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// The click event for the prehistoric pb&j
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PrehistoricPBJ();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// The click event for the Pterodactyl Wings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// The click event for the Steakosaurus Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new SteakosaurusBurger();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// The click event for the T Rex King Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new TRexKingBurger();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// The click event for the VelociWrap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new VelociWrap();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
