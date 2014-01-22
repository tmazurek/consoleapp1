using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBindingTest
{
    public class SoftwareItem
    {
        public string Name { get; set; }
        public int ISBN { get; set; }
        public string Description { get; set; }

        public static SoftwareItem GetItem()
        {
            var item1 = new SoftwareItem() {Name="Outlook", Description="Mail management tool", ISBN=12333};
            return item1;
        }
    }
}
