using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerLib
{
    public class ItemCatalog
    {
        private static Dictionary<string, Item> catalog = null;
        public static Dictionary<string, Item> getCatalog()
        {
            if (catalog == null)
            {
                loadCatalog();
            }
            return catalog;
        }

        private static void loadCatalog()
        {
            catalog = new Dictionary<string, Item>();

            string itemName = "apples";
            Item item = new Item(itemName, .50m, Item.Units.each);
            catalog.Add(itemName, item);

            itemName = "tide";
            item = new Item(itemName, 4.77m, Item.Units.each);
            catalog.Add(itemName, item);
        }
    }
}
