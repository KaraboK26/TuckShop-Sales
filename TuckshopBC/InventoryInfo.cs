using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuckshopBC
{
    public class InventoryInfo
    {
        public int inventoryID { get; set; }
        public string inventoryName { get; set; }
        public string inventoryDescribtion { get; set; }
        public double inventoryPrice { get; set; } 
        public int inventoryQuantityInStock { get; set; }
        public string inventoryReorderLevel { get; set; }  
        public string inventoryDiscontinue { get; set; }

    }
}
