using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stellar.Core.Items
{
    /// <summary>
    /// Describes an actor that will buy and sell a list of products
    /// </summary>
    public class Market
    {
        /// <summary>
        /// The name of this market
        /// </summary>
        public String Name { get; protected set; }

        /// <summary>
        /// A collection of MarketSlots describing the goods this market will trade
        /// </summary>
        public IEnumerable<MarketSlot> Slots { get; protected set; }

        public Market(String name, IEnumerable<MarketSlot> slots)
        {
            this.Name = name;
            var mySlots = new List<MarketSlot>();
            mySlots.AddRange(slots);
            this.Slots = mySlots;
        }
    }
}
