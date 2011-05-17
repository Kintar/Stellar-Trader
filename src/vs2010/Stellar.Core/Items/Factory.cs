using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stellar.Core.Items
{
    public class Factory
    {
        public virtual String Name { get; protected set; }
        public virtual Item ItemProduced { get; protected set; }
        public virtual int UnitsProduced { get; protected set; }
        public virtual float ProductionInterval { get; protected set; }
        public virtual IEnumerable<Crate> Consumption { get; protected set; }
    }
}
