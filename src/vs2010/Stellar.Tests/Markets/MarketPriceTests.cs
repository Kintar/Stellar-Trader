using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Stellar.Core.Markets;
using Stellar.Core.Items;
using Stellar.Core.Markets.Behaviors;

namespace Stellar.Tests.Markets
{
    [TestFixture]
    public class MarketPriceTests
    {
        [Test]
        public void TestFixedPercentageBehavior()
        {
            Item grain = new Item("Grain", 1, 1, 1);
            Crate grainCrate = new Crate(grain, 50);
            List<Crate> inventory = new List<Crate>();
            inventory.Add(grainCrate);
            Market m = new Market("Grainplace, Inc.", inventory);
            m.Behaviors[grain] = new FixedPercentage();
        }
    }
}
