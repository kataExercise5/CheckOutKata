using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckOutScanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOutScanner.Tests
{
    [TestClass()]
    public class ScannerTests
    {
        [TestMethod()]
        public void ScannerTestCtor()
        {
            Dictionary<string, Item> catalog = ItemCatalog.getCatalog();
            Assert.IsTrue(catalog.Count > 0);
        }
    }
}