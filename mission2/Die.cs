using System;

namespace mission2
{
    class Die
    {
        // Elements of an individual Die
        public int Val
        {
            get 
            {
                // Random number from 1 to 6 for the value and return
                var rand = new Random();
                int val = rand.Next(1, 7);
                return val;
            }
        }
    }
}
