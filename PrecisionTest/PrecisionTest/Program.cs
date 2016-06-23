using System;

namespace PrecisionTest
{
    internal class Program
    {
        private static void Main()
        {
            var seedF = 0.1f;
            var seedD = 0.1m;
            var valueF = 0f;
            var valueD = 0m;

            for (var i = 0; i < 10; i++)
            {
                valueF += seedF;
                valueD += seedD;
            }

            Console.WriteLine($"ValueF: {1 - valueF}");
            Console.WriteLine($"ValueD: {1 - valueD}");
            Console.ReadLine();
        }
    }
}
