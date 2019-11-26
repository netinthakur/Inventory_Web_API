using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory_Web_API.Model
{
    //Item details
    public class Item
    {
        //Item id
        public int  Id {get; set;}

        //Item name
        public string Name { get; set; }


        //Item code
        public string ItemCode
        {
            get { return "INV0000" + Id; }
        }

        //Item price
        public decimal Price { get; set; }

        //Item quantity
        public int Quantity { get; set; }

    }
}
