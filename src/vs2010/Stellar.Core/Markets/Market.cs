using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stellar.Core.Items;

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

        protected IDictionary<Item, Crate> crates;
        protected IDictionary<Item, double> sellPrices;
        protected IDictionary<Item, double> buyPrices;

        /// <summary>
        /// This market's inventory, expressed as an enumeration of Crates
        /// </summary>
        public IEnumerable<Crate> Inventory
        {
            get
            {
                return crates.Values;
            }
        }
        
        public Market(String name, IEnumerable<Crate> inventory)
        {
            this.Name = name;
            crates = ProjectInventoryToDictionary(inventory);
            sellPrices = new Dictionary<Item, double>();
            buyPrices = new Dictionary<Item, double>();

            foreach (Item item in AvailableItems)
            {
                sellPrices[item] = 0;
                buyPrices[item] = 0;
            }
        }

        /// <summary>
        /// Used to initialize a new market from an enumeration of crates.
        /// </summary>
        /// <param name="inventory"></param>
        /// <returns></returns>
        private IDictionary<Item, Crate> ProjectInventoryToDictionary(IEnumerable<Crate> inventory)
        {
            var newInventory = new Dictionary<Item, Crate>();
            foreach (var crate in inventory)
            {
                if (newInventory.ContainsKey(crate.Item))
                {
                    var oldCrate = newInventory[crate.Item];
                    var newCrate = new Crate(crate.Item, oldCrate.Quantity + crate.Quantity);
                    newInventory[crate.Item] = newCrate;
                }
                else
                {
                    newInventory[crate.Item] = crate;
                }
            }

            return newInventory;
        }

        public IEnumerable<Item> AvailableItems
        {
            get { return crates.Keys; }
        }

    }
}
