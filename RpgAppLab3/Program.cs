﻿using System;
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

            Console.WriteLine("Enter a command:");
            var command = Console.ReadLine();

            if (command == "dice roll")
            {
                var roll = rnd.Next(20) + 1;
                if (roll <= 4)
                {
                    Console.WriteLine("D4 was rolled");
                }

                else if (roll <= 8)
                {
                    Console.WriteLine($"Roll D8 dice. Result: {roll}");
                }

                else if (roll <= 10)
                {
                    Console.WriteLine("d10");
                }

                else 
                {
                    Console.WriteLine("D20");
                }
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
