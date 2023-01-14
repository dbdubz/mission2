using System;

namespace mission2
{
    class Program
    {
        static void Main(string[] args)
        { 
            int nRolls;
            int rollTotal;
            int cRoll = 0;
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.Write("How many dice rolls would you like to simulate? ");
            nRolls = Convert.ToInt32(Console.ReadLine());

            while (cRoll < nRolls)
            {
                rollTotal = Dice.Roll();

            }
        }
    }
}
