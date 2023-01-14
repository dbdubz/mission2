﻿using System;
using System.Collections.Generic;

namespace mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable declarations
            int nRolls;
            int rollTotal;
            Dictionary<int, int> rollCount = new Dictionary<int, int>();
            Dictionary<int, string> outcomes = new Dictionary<int, string>();
            int cRoll = 0;
            int possible = 2;

            // Set up possible roll counts for ending output.
            // Chose a dictionary because it seemed like the simplist option for doing this
            while (possible < 13)
            {
                rollCount.Add(possible, 0);
                outcomes.Add(possible, "");
                possible += 1;
            }

            // Game Start print
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.Write("How many dice rolls would you like to simulate? ");

            // Get number of rolls
            nRolls = (int)Convert.ToInt64(Console.ReadLine());

            // Perform the rolls
            while (cRoll < nRolls)
            {
                Roll roll = new Roll();
                rollTotal = roll.Total();            // Creates a roll instance
                rollCount[rollTotal] += 1;
                cRoll += 1;
            }

            // Print Results header
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {nRolls}.\n");

            // Get % of rolls for each value
            foreach (KeyValuePair<int, int> n in rollCount)
            {
                int key = n.Key;
                int val = n.Value;
                int p = (int)Math.Round(((val / (decimal)nRolls) * 100), 0);
                int x = 0;

                // Convert the percentages to *
                while (x < p)
                {
                    outcomes[key] += "*";
                    x += 1;
                }
            }

            // Print the output
            foreach (KeyValuePair<int, string> n in outcomes)
            {
                int key = n.Key;
                string val = n.Value;

                if (key < 10)
                {
                    Console.WriteLine($"0{key}: {val}");
                }
                else
                {
                    Console.WriteLine($"{key}: {val}");
                }
            }

            // End game
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
