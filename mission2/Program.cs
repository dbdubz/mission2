using System;
using System.Collections.Generic;       // Library to allow for dictionary use

namespace mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nRolls = Game.Start();
            Dictionary<int, string> outcomes = Game.Play(nRolls);
            Game.End(nRolls, outcomes);
        }
    }
}
