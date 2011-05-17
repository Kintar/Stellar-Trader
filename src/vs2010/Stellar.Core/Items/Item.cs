using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stellar.Core.Items
{
    public class Item
    {
        public virtual String Name { get; protected set; }
        public virtual float BaseValue { get; protected set; }
        public virtual float Weight { get; protected set; }
        public virtual float Volume { get; protected set; }
    }
}
