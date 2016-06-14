using System;

namespace CoinToss2
{
    class Program
    {
        static void Main()
        {
            var coin = new Random();

            Console.Write("Enter your guess, Heads or Tales \"H\" or \"T\": ");
            var guess = Console.ReadLine();

            var coinToss = coin.Next(0, 2);
            var coinDescription = coinToss == 0 ? "Tails" : "Heads";

            if ((guess?.ToLower() == "t" && coinToss == 0) || (guess?.ToLower() == "h" && coinToss == 1))
                Console.WriteLine($"The coin toss was {coinDescription}, You win!");

            else
                Console.WriteLine($"Coin toss was {coinDescription}, you lose!");

            Console.ReadLine();
        }
    }
}
