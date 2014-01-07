using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Warehouse
    {
        public int WarehouseID { get; set; }
        public string WarehouseName { get; set; }

        public Warehouse(string Name, int ID)
        {
            WarehouseName = Name;
            WarehouseID = ID;
        }
        public Item FinAndReturnItem(int ItemID)
        {
            Item returnItem = new Item() { ID = ItemID, Name="micr office 2001" };
            return returnItem;
        }
    }
}
