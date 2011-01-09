using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Stellar.Core.Products
{
    /// <summary>
    /// Represents a quantity of a given product, along with the production/purchase cost associated
    /// with the product at the time the Supply was created.
    /// </summary>
    [DataContract(Namespace = "http://infinities-within.net/games/StellarTrader")]
    public class Supply
    {
        [DataMember(IsRequired=true)]
        public Product Product { get; protected set; }
        [DataMember(IsRequired = true)]
        public int Quantity { get; protected set; }
        [DataMember(IsRequired = true)]
        public double Cost { get; protected set; }

        public Supply(Product product, double cost)
        {
            this.Product = product;
            this.Cost = cost;
        }
    }
}
