using System;
using System.Collections.Generic;
using System.Text;

namespace mission2
{
    class Dice
    {
        private static int Die()
        {
            int[] sides = { 1, 2, 3, 4, 5, 6 };
            List<int> options = new List<int>(sides);
            var rand = new Random();

            int die = rand.Next(options.Count);

            return die;
        }

        public static int Roll()
        {
            int roll;
            int dieA;
            int dieB;

            dieA = Die();
            dieB = Die();

            roll = dieA + dieB;

            return roll;
        }
    }
}
