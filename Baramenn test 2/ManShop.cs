using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baramenn_test_2
{
    internal class ManShop
    {
        public List<Items> ItemShop { get; set; }
        public void ShopMenu()
        {
            while (true)
            {
                Console.WriteLine("Hello and welcome to the manliest shop there is");
                Console.WriteLine("What would you like to buy?");
                Console.WriteLine("1) check out what's on offer!");
                Console.WriteLine("2) leave");


                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        PrintItemInfo();
                        break;
                    case "2":
                        MainMenu();
                        break;

                }
            }
        }

        public void PrintItemInfo()
        {
            List<Items> items = new List<Items>();
            Items item1 = new Items(200, "Tanktop", 0);
            items.Add(item1);
            Items item2 = new Items(300, "An oddly shaped object", 1);
            items.Add(item2);
            Items item3 = new Items(50, "Potion of some kind. Who knows what it's for", 2);
            items.Add(item3);
            Items item4 = new Items(55, "A pair of sunglasses for extra charm", 3);
            items.Add(item4);
            Items item5 = new Items(150, "A sparkly collar adored with gems", 4);
            items.Add(item5);
            Items item6 = new Items(500, "A leather harness. Why?", 5);
            items.Add(item6);

            Console.WriteLine("Items in shop");
            foreach (Items item in items)
            {
                Console.WriteLine($"Item name: {item.ItemName}, Price: {item.Price}, ID: {item.ID}");
            };
            buyMenu();
        }
        void buyMenu() { 
            Console.WriteLine("Type the item's ID to buy it");

                string menu = Console.ReadLine();
                if (menu == "0")
                    {
                 //       Console.WriteLine($"You bought a: " + );
                    }
                else if (menu == "1")
                    {
                  //  Console.WriteLine($"You bought a: {item2.ItemName}");
                      
                    }
                   
                }
            
        public void MainMenu()
        {
            BaraWorld world = new BaraWorld();
        }



    }
}







      



