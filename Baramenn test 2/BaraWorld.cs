using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baramenn_test_2
{
    internal class BaraWorld
    {
        public BaraList Bara { get; set; }
        public ManShop Store { get; set; }

        public BaraWorld()
        {
            Store = new ManShop();
            Bara = new BaraList();

            MainMenu();
        }
        public void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("Welcome to BaraWorld");
                Console.WriteLine("What - or who- do you want to do?");
                Console.WriteLine("1) Enter the wilderness of men");
                Console.WriteLine("2) Go to shop");
                Console.WriteLine("3) Go to bar");
                Console.WriteLine("4) Log off?");

                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        EnterTheWilderness();
                        break;
                    case "2":
                        GoToShop();
                        break;
                    case "3":

                        break;
                    default:

                        break;
                }
            }
        }
        public void EnterTheWilderness()
        {
            var bara = new BaraList();
            bara.EnterTheWilderness();
        }
        public void GoToShop()
        {
            var shop = new ManShop();
            shop.ShopMenu();
           
            
        }
    }
   
}