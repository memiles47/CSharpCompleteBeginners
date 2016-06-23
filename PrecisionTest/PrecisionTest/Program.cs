using System;

namespace PrecisionTest
{
    class Program
    {
        static void Main()
        {
            var seedF = 0.1f;
            var seedD = 0.1m;
            var valueF = 0f;
            var valueD = 0m;

            for (int i = 0; i < 10; i++)
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
