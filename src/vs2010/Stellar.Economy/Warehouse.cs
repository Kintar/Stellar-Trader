using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfinitySystem;

namespace Stellar.Economy
{
    public class Warehouse : Component
    {
        public IEnumerable<Stock> Stocks { get; set; }

        public Warehouse()
        {
            Stocks = new HashSet<Stock>();
        }
    }
}
