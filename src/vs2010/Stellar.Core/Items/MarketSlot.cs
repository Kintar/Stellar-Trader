using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stellar.Core.Items
{
    public class MarketSlot
    {
        public virtual Crate Crate { get; protected set; }
        public virtual float SellPrice { get; protected set; }
        public virtual float BuyPrice { get; protected set; }
    }
}
