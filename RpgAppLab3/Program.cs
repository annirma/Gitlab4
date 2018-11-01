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
            if (command == "names")
            {
                var allNames = new[] { "Briana", "Ben", "David",
            "Dana", "Felicia", "Felix" };
                var randomIndex = rnd.Next(allNames.Length);
                Console.WriteLine(allNames[randomIndex]);
            }
            Console.ReadKey();
        }
    }
}
