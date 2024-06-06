using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baramenn_test_2
{
    public class Items
    {
        public int Price { get; set; }
        public string ItemName { get; set; }
        public int ID { get; set; }

        public Items(int price, string itemName, int id) 
        {
            ItemName = itemName;
            Price = price;
            ID = id;
        }
    }
}
