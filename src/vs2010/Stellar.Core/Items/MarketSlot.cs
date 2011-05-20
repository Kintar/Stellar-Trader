using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stellar.Core.Items
{
    /// <summary>
    /// A MarketSlot describes a quantity of an item, and the buy and sell price for units of that item.
    /// </summary>
    public class MarketSlot
    {
        /// <summary>
        /// The market slot's currently available quantity of an item
        /// </summary>
        public virtual Crate Crate { get; protected set; }

        /// <summary>
        /// The current price the parent market charges for its product
        /// </summary>
        public virtual float SellPrice { get; protected set; }

        /// <summary>
        /// The current price the parent market will pay for its product
        /// </summary>
        public virtual float BuyPrice { get; protected set; }

        public MarketSlot(Crate crate, float sellPrice, float buyPrice)
        {
            this.Crate = crate;
            this.SellPrice = sellPrice;
            this.BuyPrice = buyPrice;
        }
    }
}
