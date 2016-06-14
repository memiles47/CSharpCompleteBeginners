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

            if (guess?.ToLower() == "h" && coinToss == 1)
                Console.WriteLine("The coin toss was Heads, You win!");

            else if (guess?.ToLower() == "t" && coinToss == 0)
                Console.WriteLine("THe coin toss was Tales, You win!");

            else
                Console.WriteLine(coinToss == 0 ? "Coin toss was tales, you lose!" : "Coin toss was heads, you lose!");

            Console.ReadLine();
        }
    }
}
