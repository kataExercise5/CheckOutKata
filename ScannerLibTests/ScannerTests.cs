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
    public class ScannerTests
    {
        [TestMethod()]
        public void ScannerTest()
        {
            DateTime dt = new DateTime(2018, 11, 19);
            Scanner scanner = new Scanner(dt);
            Assert.IsTrue(scanner.getCatalogCount() > 0);
        }
    }
}