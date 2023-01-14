namespace mission2
{
    class Roll
    {
        // Defines what a roll is
        // Creates an instace of 2 dice (a and b), adds them together and return the roll total
        public int RollTotal
        {
            get
            {
                // Instance of die A
                Die dieA = new Die();

                // Instance of die B
                Die dieB = new Die();

                // Calculate roll value and return
                int roll = dieA.Val + dieB.Val;
                return roll;
            }
        }
    }
}
