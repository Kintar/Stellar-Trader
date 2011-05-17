using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stellar.Core.Items
{
    public class Market
    {
        public String Name { get; protected set; }
        public IEnumerable<MarketSlot> Slots { get; protected set; }
    }
}
