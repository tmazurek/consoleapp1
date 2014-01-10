using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual void Purchase()
        {
            Console.WriteLine("\nPurchasing {0}", Name);
        }

        public static Item GetItem()
        {
            var newItem = new Item() {ID=1, Name="item1" };
            return newItem;
        }
    }
    
    class Software : Item
    {
        public string ISBN { get; set; }
    }

    class Hardware : Item
    {
        public string SerialNumber { get; set; }
        public override void Purchase()
        {
            base.Purchase();
            Console.WriteLine("serial number is:{0}", SerialNumber);
        }
    
    }

    class Computer : Hardware
    {
        public string CPUType { get; set; }
        public string Disks { get; set; }
        public override void Purchase()
        {
            base.Purchase();
            Console.WriteLine("my computers cpu type is {0}",CPUType);
        }

    }
    class Peripheral : Hardware
    {
        public string Description { get; set; }
        public override void Purchase()
        {
            base.Purchase();
            Console.WriteLine("peripheral description:{0}",Description);
        }
    
    }
}
