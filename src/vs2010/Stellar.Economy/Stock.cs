using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfinitySystem;

namespace Stellar.Economy
{
    public class Stock : Component
    {
        private ItemDefinition myItem = ItemDefinition.Nonexistium;

        public ItemDefinition Item
        {
            get { return myItem; }
            set { myItem = value; }
        }

        public int Quantity { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Stock && Item.Equals(((Stock)obj).Item);
        }

        public override int GetHashCode()
        {
            return myItem.GetHashCode();
        }
    }
}
