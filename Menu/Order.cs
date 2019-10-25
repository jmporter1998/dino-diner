using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    /// <summary>
    /// The class that holds the data for the order
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The items on the order
        /// </summary>
        private List<IOrderItem> items;

        public IOrderItem[] Items
        {
            get { return items.ToArray(); }
        }


        /// <summary>
        /// The subtotal for the order
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotal = 0;
                foreach (IOrderItem item in Items)
                {
                    subtotal += item.Price;
                }
                return subtotal;
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

        /// <summary>
        /// The constructor for the order
        /// </summary>
        public Order()
        {
            items = new List<IOrderItem>();
        }

        /// <summary>
        /// Adds an Item
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
        }

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));

        }
    }
}
