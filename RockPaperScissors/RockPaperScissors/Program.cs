using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter \"Rock\", \"Paper\" or \"Scissors\": ");
            var guess = Console.ReadLine().ToLower();

            Console.ReadLine();
        }
    }
}
