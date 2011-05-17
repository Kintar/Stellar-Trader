using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stellar.Core.Items
{
    public class Crate
    {
        public Item Item { get; protected set; }
        public int Quantity { get; protected set; }
    }
}
