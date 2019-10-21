using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The order item interface
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price property
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The description property
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The special property
        /// </summary>
        string[] Special { get; }
    }
}
