using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stellar.Economy
{
    /// <summary>
    /// Describes a method for producing an item given input materials and time.
    /// </summary>
    public class FactoryDefinition
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
        public IEnumerable<Stock> Consumption { get; protected set; }

        /// <summary>
        /// The list of items produced by this factory and the quantity produced in a ProductionInterval
        /// </summary>
        public IEnumerable<Stock> Production { get; protected set; }

        public FactoryDefinition(String name, double productionInterval, IEnumerable<Stock> consumption, IEnumerable<Stock> production)
        {
            this.Name = name;
            this.ProductionInterval = productionInterval;
            List<Stock> tempList = new List<Stock>();
            tempList.AddRange(consumption);
            this.Consumption = tempList;
            tempList = new List<Stock>();
            tempList.AddRange(production);
            this.Production = tempList;
        }
    }
}
