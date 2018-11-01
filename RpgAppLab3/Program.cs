using System;
using System.Collections.Generic;

namespace RpgAppLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();

            var names = new List<string>()
            {
                "Alexa",
                "Ciri",
                "Phantasma",
                "Keeloo",
                "Ryu",
                "Zangief",
            };

            Console.WriteLine("Roll the dice!");
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
            } else if (command == "names")
            {
                Console.WriteLine($"Your random name is: {names[rnd.Next(names.Count)]}");
            }

            Console.ReadKey();
        }
    }
}
