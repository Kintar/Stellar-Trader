using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stellar.Core.Items
{
    /// <summary>
    /// A discrete quantity of an item
    /// </summary>
    public class Crate
    {
        /// <summary>
        /// The contained item
        /// </summary>
        public Item Item { get; protected set; }

        /// <summary>
        /// The quantity contianed
        /// </summary>
        public int Quantity { get; protected set; }

        public Crate(Item item, int quantity)
        {
            this.Item = item;
            this.Quantity = quantity;
        }
    }
}
