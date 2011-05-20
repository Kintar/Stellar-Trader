using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stellar.Core.Items
{
    /// <summary>
    /// Describes a method for producing an item given input materials and time.
    /// </summary>
    public class Factory
    {
        /// <summary>
        /// The name of this factory. E.g., "Low-Tech Steel Foundry"
        /// </summary>
        public String Name { get; protected set; }

        /// <summary>
        /// The duration of a production run in game time units
        /// </summary>
        public double ProductionInterval { get; protected set; }

        /// <summary>
        /// The list of items consumed by this factory and the quantity consumed in a ProductionInterval
        /// </summary>
        public IEnumerable<Crate> Consumption { get; protected set; }

        /// <summary>
        /// The list of items produced by this factory and the quantity produced in a ProductionInterval
        /// </summary>
        public IEnumerable<Crate> Production { get; protected set; }

        public Factory(String name, double productionInterval, IEnumerable<Crate> consumption, IEnumerable<Crate> production)
        {
            this.Name = name;
            this.ProductionInterval = productionInterval;
            List<Crate> tempList = new List<Crate>();
            tempList.AddRange(consumption);
            this.Consumption = tempList;
            tempList = new List<Crate>();
            tempList.AddRange(production);
            this.Production = tempList;
        }
    }
}
