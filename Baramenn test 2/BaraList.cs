using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Baramenn_test_2
{
    public class BaraList
    {
        public List<Bara> WildMen { get; set; }

        public void EnterTheWilderness()
        {
            while (true)
            {

                Console.WriteLine("What terrain, and men, would you like to explore?");
                Console.WriteLine("1) Forest");
                Console.WriteLine("2) The streets");
                Console.WriteLine("3) The alleyways");
                Console.WriteLine("4) Back");

                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        PrintBaraInfoForest();
                        break;
                    case "2":
                        PrintBaraInfoStreet();
                        break;
                }
            }
        }

        public void PrintBaraInfoForest()
        {
            List<Bara> baras = new List<Bara>();
            Bara bara1 = new Bara("Kyle", "Bear", 40);
            Bara bara2 = new Bara("Tyler", "Bear", 45);
            baras.Add(bara1);
            baras.Add(bara2);

            Console.WriteLine("Men of the forest");
            foreach (Bara bara in baras)
            {
                Console.WriteLine($"Name: {bara.Name}, Type: {bara.Type}");
            };
            BattleMenu1(baras);
        }

        public void PrintBaraInfoStreet()
        {
            List<Bara> baras = new List<Bara>();
            Bara bara1 = new Bara("Jeff", "Otter", 20);
            Bara bara2 = new Bara("Chad", "Otter", 22);
            baras.Add(bara1);
            baras.Add(bara2);

            Console.WriteLine("Men in the Streets");
            foreach (Bara bara in baras)
            {
                Console.WriteLine($"Name: {bara.Name}, Type: {bara.Type}");
            };
            BattleMenu2(baras);
        }

        void BattleMenu1(List<Bara> baras)
        {

            int health = 79;

            int strength = 25;
            int trainerHealth = 80;


            while (true)
            {

                Console.WriteLine("1) to flirt");
                Console.WriteLine("2) to compliment ");
                Console.WriteLine("4) flee the battle");

                string battle = Console.ReadLine();


                Console.WriteLine("they have a health of  " + health + " and strength of  " + strength);
                Console.WriteLine("you have a health of  " + trainerHealth);

                if (battle == "1")
                {
                    Console.WriteLine($"you flirted with {baras[0].Name}. He blushes and looses 10 health");
                    health -= 10;
                    Console.WriteLine($" {baras[1].Name} decided to flirt back for " + strength);
                    trainerHealth -= strength;
                }
                if (battle == "2")
                {
                    Console.WriteLine($"No one can resist a good compliment! {baras[1].Name} takes it well though and looses only 2 health");
                    health -= 2;

                }
                if (battle == "4")
                {
                    MainMenu();
                }

            }
        }
           
            void BattleMenu2(List<Bara> baras)
            {
                int health = 69;

                int strength = 15;
                int trainerHealth = 80;


                while (true)
                {

                    Console.WriteLine("1) to flirt");
                    Console.WriteLine("2) to compliment ");

                    string battle = Console.ReadLine();


                    Console.WriteLine("otters have a health of  " + health + " and strength of  " + strength);
                    Console.WriteLine("you have a health of  " + trainerHealth);

                    if (battle == "1")
                    {
                        Console.WriteLine($"you flirted with {baras[2].Name}. He blushes and looses 10 health");
                        health -= 10;
                        Console.WriteLine($" {baras[3].Name} decided to flirt back for " + strength);
                        trainerHealth -= strength;
                    }
                    if (battle == "2")
                    {
                        Console.WriteLine($"No one can resist a good compliment! {baras[3].Name} takes it well though and looses only 2 health");
                        health -= 2;

                    }
                }
            }

        public void MainMenu()
        {
            Console.WriteLine("You have left the battle");
            BaraWorld world = new BaraWorld();
        }
    }
    }



        
  

