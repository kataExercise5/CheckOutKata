using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScannerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerLib.Tests
{
    [TestClass()]
    public class ItemTests
    {
        [TestMethod()]
        public void calcPriceTestForEach()
        {
            Item apple = new Item("apple", .80m, Item.Units.each);
            Assert.IsTrue(apple.calcPrice(3, new DateTime()) == 2.40m);
        }

        [TestMethod()]
        public void calcPriceTestForPounds()
        {
            Item apple = new Item("apple", 1m, Item.Units.pounds);
            Assert.IsTrue(apple.calcPrice(3.5m, new DateTime()) == 3.50m);
        }
    }
}