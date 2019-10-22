using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The class that holds the data for the order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// The items on the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }

        /// <summary>
        /// The subtotal for the order
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotal = 0;
                if (Items.Count != 0)
                {
                    foreach (IOrderItem item in Items)
                    {
                        subtotal += item.Price;
                    }
                }
                if (subtotal > 0) return subtotal;
                else return 0;
            }
        }

        /// <summary>
        /// Stores the sales tax rate that will be applied to the order
        /// </summary>
        public double SalesTaxRate { get; protected set; }

        /// <summary>
        /// The total cost of the sales tax
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate*SubtotalCost;
            }
        }

        /// <summary>
        /// The total cost for the order
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }





    }
}
