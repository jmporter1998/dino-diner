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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        private DinoNuggets nuggets;

        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="nuggets"></param>
        public CustomizeDinoNuggets(DinoNuggets nuggets)
        {
            InitializeComponent();
            this.nuggets = nuggets;
        }

        /// <summary>
        /// The event handler for the add nugget button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddNugget(object sender, RoutedEventArgs e)
        {
            nuggets.AddNugget();
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
