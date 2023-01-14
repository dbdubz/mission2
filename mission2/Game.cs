using System;
using System.Collections.Generic;
using System.Linq;

namespace mission2
{
    class Game
    {
        public static int Start()
        {
            int nRolls;

            // Game Start print
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.Write("How many dice rolls would you like to simulate? ");

            // Get number of rolls and play the game
            nRolls = (int)Convert.ToInt64(Console.ReadLine());

            return nRolls;
        }
        public static Dictionary<int, string> Play(int nRolls)
        { 
            int rollTotal;
            int val;
            int percentage;
            int n;
            int cRoll = 0;
            int possible = 2;
            Dictionary<int, string> outcomes = new Dictionary<int, string>();

            while (possible < 13)
            {
                outcomes.Add(possible, "");
                possible += 1;
            }

            int[] rollVals = new int[nRolls];

            // Perform the rolls
            while (cRoll < nRolls)
            {

                // Creates a roll instance
                Roll roll = new Roll();

                // Calls the Total method
                rollTotal = roll.Total();
                rollVals[cRoll] = rollTotal;
                cRoll += 1;
            }

            possible = 2;
            
            while (possible < 13)
            {
                val = rollVals.Count(r => r == possible);

                // Convert the roll % to an int, rounded
                percentage = (int)Math.Round(((val / (decimal)nRolls) * 100), 0);
                n = 0;

                // Convert the percentages to *
                while (n < percentage)
                {
                    outcomes[possible] += "*";
                    n += 1;
                }

                possible += 1;
            }

            return outcomes;
        }

        public static void End(int nRolls, Dictionary<int, string> outcomes)
        {
            // Print Results header
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {nRolls}.\n");


            // Print the output, omitting 1 as a val because it is impossible
            foreach (KeyValuePair<int, string> x in outcomes)
            {
                int key = x.Key;
                string s = x.Value;

                if (key < 10)
                {

                    // Format 2-9 so they are flush with 10-12
                    Console.WriteLine($"0{key}: {s}");
                }
                else
                {
                    Console.WriteLine($"{key}: {s}");
                }
            }

            // End game
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
