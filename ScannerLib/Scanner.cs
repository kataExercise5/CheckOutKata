using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerLib
{
    public class Scanner
    {
        private DateTime purchaseDate;
        private Dictionary<string, Item> catalog;
        public int getCatalogCount()
        {
            return catalog.Count;
        }

        public Scanner(DateTime purchDate)
        {
            purchaseDate = purchDate;
            catalog = ItemCatalog.getCatalog();
        }
    }
}
