using System;
using System.Collections.Generic;

namespace RpgAppLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.WriteLine("Enter a command:");
            var command = Console.ReadLine();

            if (command == "roll d10")
            {
                int diceRoll = rnd.Next(1, 10 + 1);
                Console.WriteLine($"Rolled a D10: {diceRoll}");
            }
            else if (command == "roll D8")
            {
                var randomIndex = rnd.Next(1, 8 + 1);
                Console.WriteLine(randomIndex);
            }
            else if(command == "!roll D4")
            {
                Console.WriteLine($"You rolled a {rnd.Next(1, 4 + 1)}");
            }
            Console.ReadKey();

            var equipment = new List<string>()
            {
                "plate",
                "fork",
                "spoon",
            };

            if (command == "equipment")
            {
                int rndIndx = rnd.Next(0, equipment.Count);
                Console.WriteLine($"Congratz, you just found a {equipment[rndIndx]}");
            }
        }
    }
}
