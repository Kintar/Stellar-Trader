using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfinitySystem;

namespace Stellar.Economy
{
    public class ItemFactory : Component
    {
        public FactoryDefinition FactoryDefinition { get; set; }
        public bool ProductionStarted { get; set; }
        public double ProductionProgress { get; set; }
    }
}
