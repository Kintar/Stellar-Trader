using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stellar.Core.Items;

namespace Stellar.Core.Markets.Behaviors
{
    public interface IMarketBehavior
    {
        /// <summary>
        /// The globally-unique name of this market behavior
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Calculates the price of a sell (market-to-customer) transaction
        /// </summary>
        /// <param name="item"></param>
        /// <param name="quantityOnHand"></param>
        /// <param name="orderQuantity"></param>
        /// <returns></returns>
        double CalculateSellPrice(Item item, int quantityOnHand, int orderQuantity);

        /// <summary>
        /// Calculates the price of a buy (customer-to-market) transaction
        /// </summary>
        /// <param name="item"></param>
        /// <param name="quantityOnHand"></param>
        /// <param name="orderQuantity"></param>
        /// <returns></returns>
        double CalculateBuyPrice(Item item, int quantityOnHand, int orderQuantity);
    }
}
