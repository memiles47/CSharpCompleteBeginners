using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main()
        {
            var game = new PlayGame();
            var userGuess = string.Empty;
            var rps = new Random();
            var userScore = 0;
            var computerscore = 0;

            while (userGuess != "quit")
            {
                Console.Clear();
                Console.Write("Enter \"Rock\", \"Paper\", \"Scissors\" or \"Quit\": ");
                userGuess = Console.ReadLine()?.ToLower();

                if (userGuess != "rock" && userGuess != "paper" && userGuess != "scissors" && userGuess != "quit")
                {
                    Console.WriteLine("Must enter Rock, Paper, Scissors or Quit");
                    Console.Write("Press Enter to continue");
                    Console.ReadLine();
                    continue;
                }

                var computerGuess = rps.Next(1,4);

                if (userGuess == "rock")
                    game.Rock(computerGuess);
                else if (userGuess == "paper")
                    game.Paper(computerGuess);
                else if (userGuess == "scissors")
                    game.Scissors(computerGuess);
            }
        }
    }
}
