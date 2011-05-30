using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfinitySystem;

namespace Stellar.Economy
{
    public class MarketValue : Component
    {
        public double SellPrice { get; set; }
        public double BuyPrice { get; set; }
        public ItemDefinition ItemDefinition { get; set; }
    }
}
