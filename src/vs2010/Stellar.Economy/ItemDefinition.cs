using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stellar.Economy
{
    /// <summary>
    /// The core description of an item in the game world.  Immutable.
    /// </summary>
    public class ItemDefinition
    {
        /// <summary>
        /// Used in place of null item definition references for components that should never contain a null reference.
        /// For example: Stock
        /// </summary>
        public static readonly ItemDefinition Nonexistium = new ItemDefinition("Nonexistium", 0.0, 0.0, 0.0);

        /// <summary>
        /// Human-readable name of the item
        /// </summary>
        public String Name { get; protected set; }

        /// <summary>
        /// Base value of the item in currency units
        /// </summary>
        public double BaseValue { get; protected set; }

        /// <summary>
        /// Mass of the item in kilograms
        /// </summary>
        public double Mass { get; protected set; }

        /// <summary>
        /// Volume of the item in cubic meters
        /// </summary>
        public double Volume { get; protected set; }

        public ItemDefinition(String name, double baseValue, double mass, double volume)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");

            this.Name = name;
            this.BaseValue = baseValue;
            this.Mass = mass;
            this.Volume = volume;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ItemDefinition))
                return false;
            else
            {
                return obj != null && ((ItemDefinition)obj).Name.Equals(Name);
            }
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
