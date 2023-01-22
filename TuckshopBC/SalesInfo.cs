using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuckshopBC
{
    public class SalesInfo
    {
        string ProductName, Description;
        double CostPrice, GrossValue, NetProfit;
        int InventoryID,QuantitySold;

        public int InventoryID1 { get => InventoryID; set => InventoryID = value; }
        public string ProductName1 { get => ProductName; set => ProductName = value; }
        public string Description1 { get => Description; set => Description = value; }
        public int QuantitySold1 { get => QuantitySold; set => QuantitySold = value; }
        public double CostPrice1 { get => CostPrice; set => CostPrice = value; }
        public double GrossValue1 { get => GrossValue; set => GrossValue = value; }
        public double NetProfit1 { get => NetProfit; set => NetProfit = value; }
        
        
    }
}
