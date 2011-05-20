using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stellar.Core.Items;
using Stellar.Core.Markets.Behaviors;

namespace Stellar.Core.Markets
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
        /// This market's inventory, expressed as a collection of Crates
        /// </summary>
        public IEnumerable<Crate> Inventory { get; protected set; }

        /// <summary>
        /// The behviors this market applies to transactions for its goods
        /// </summary>
        public IDictionary<Item, IMarketBehavior> Behaviors { get; protected set; }

        public Market(String name, IEnumerable<Crate> inventory)
        {
            this.Name = name;
            var mySlots = new List<Crate>();
            mySlots.AddRange(inventory);
            this.Inventory = mySlots;
        }

    }
}
