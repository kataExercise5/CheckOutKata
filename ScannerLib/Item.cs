using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerLib
{
    public class Item
    {
        public enum Units { each, pounds };
        private string itemName;
        private decimal itemPrice;
        private Units itemUnit;

        public Item(string name, decimal price, Units unit)
        {
            itemName = name;
            itemPrice = price;
            itemUnit = unit;
        }

        public decimal calcPrice(int qty, DateTime purchaseDate)
        {
            return 3.0m;
        }

        public decimal calcPrice(decimal pounds, DateTime purchaseDate)
        {
            return 4.0m;
        }
    }
}
