using System;

namespace RpgAppLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.WriteLine("What do you need?");
            var command = Console.ReadLine();

            if (command == "diced4")

                Console.WriteLine("D4 was rolled");

            if (command == "diced8")
            {
                var roll = rnd.Next(8) +1;
                Console.WriteLine($"Roll D8 dice. Result: {roll}");
            }

            if (command == "diced10")
            {
                Console.WriteLine("d10");
            }

            if (command == "diced100")
            {
                var roll = rnd.Next(100) + 1;
                Console.WriteLine($"Roll D100 dice. Result: {roll}");
            }

            if (command == "names")
            {
                var allNames = new[] { "Briana", "Ben", "David",
            "Dana", "Felicia", "Felix", "Max", "Annelie" };
                var randomIndex = rnd.Next(allNames.Length);
                Console.WriteLine(allNames[randomIndex]);
            }

            if (command == "equipment")
            {
                var equipment = new[] { "Helmet", "Sword", "Shield", "Staff", "Hat", "Shirt", "Axe" };
                var randomIndex = rnd.Next(equipment.Length);
                Console.WriteLine(equipment[randomIndex]);
            }
            Console.ReadKey();
        }
    }
}
