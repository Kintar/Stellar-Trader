using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stellar.Core.Items;

namespace Stellar.Core.Markets.Behaviors
{
    public class FixedPercentage : IMarketBehavior
    {
        public double BuyMultiplier { get; protected set; }
        public double SellMultiplier { get; protected set; }

        public string Name
        {
            get { return "Fixed Markup"; }
        }

        public double CalculateSellPrice(Item item, int quantityOnHand, int orderQuantity)
        {
            return (item.BaseValue * SellMultiplier) * orderQuantity;
        }

        public double CalculateBuyPrice(Item item, int quantityOnHand, int orderQuantity)
        {
            return (item.BaseValue * BuyMultiplier) * orderQuantity;
        }
    }
}
