using System;

namespace LuckySevens
{
    class Program
    {
        static void Main()
        {
            var dieRoll = new Random();
            int die1, die2, rollNumber = 0;

            for (int i = 1; i < 101; i++)
            {
                die1 = dieRoll.Next(1, 7);
                die2 = dieRoll.Next(1, 7);

                if (die1 + die2 == 7)
                    rollNumber++;
            }

            Console.WriteLine($"Rolled seven {rollNumber} time(s)");
            Console.ReadLine();
        }
    }
}
