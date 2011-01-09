using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Stellar.Core.Products
{
    [DataContract(Namespace="http://infinities-within.net/games/StellarTrader")]
    public class Product
    {
        [DataMember(IsRequired = true)]
        public String Name { get; protected set; }

        [DataMember(IsRequired = true)]
        public Double BaseValue { get; protected set; }

        public Product(String name, Double baseValue)
        {
            this.Name = name;
            this.BaseValue = baseValue;
        }
    }
}
