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

        //constructor
        public Warehouse(string Name, int ID)
        {
            WarehouseID = ID;
            WarehouseName = Name;
        }
        //methods
        public Item FinAndReturnItem(int ItemID)
        {
            
            Item returnItem = new Item() { ID = ItemID, Name="office 2011" };
            return returnItem;
        }
    }
}
