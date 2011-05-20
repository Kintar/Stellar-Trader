using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stellar.Core.Items
{
    /// <summary>
    /// The core description of an item in the game world.  Immutable.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Human-readable name of the item
        /// </summary>
        public String Name { get; protected set; }

        /// <summary>
        /// Base value of the item in currency units
        /// </summary>
        public float BaseValue { get; protected set; }

        /// <summary>
        /// Mass of the item in kilograms
        /// </summary>
        public float Mass { get; protected set; }

        /// <summary>
        /// Volume of the item in cubic meters
        /// </summary>
        public float Volume { get; protected set; }

        public Item(String name, float baseValue, float mass, float volume)
        {
            this.Name = name;
            this.BaseValue = baseValue;
            this.Mass = mass;
            this.Volume = volume;
        }
    }
}
