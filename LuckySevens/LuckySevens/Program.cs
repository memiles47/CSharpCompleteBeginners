using System;

namespace LuckySevens
{
    class Program
    {
        static void Main()
        {
            var dieRoll = new Random();
            var rollNumber = 0;

            for (var i = 1; i < 101; i++)
            {
                var die1 = dieRoll.Next(1, 7);
                var die2 = dieRoll.Next(1, 7);

                if (die1 + die2 == 7)
                    rollNumber++;
            }

            Console.WriteLine($"Rolled seven {rollNumber} time(s)");
            Console.ReadLine();
        }
    }
}
