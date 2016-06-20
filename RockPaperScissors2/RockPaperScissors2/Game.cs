using System;

namespace RockPaperScissors2
{
    internal class Game
    {
        private int _wins;
        private int _losses;
        private int _ties;
        private readonly Random _rng = new Random();

        public void PlayGame()
        {
            while (true)
            {
                var userInput = PromptPlayer();
                if (userInput == "q")
                    return;

                ChooseAndCheckForWinner(userInput);
                DisplayScore();
            }
        }

        public void DisplayScore()
        {
            Console.Write($"\nWins: {_wins}\nLosses: {_losses}\nTies: {_ties}\n\n");
            Console.Write("Press Enter to Continue...");
            Console.ReadLine();

        }

        private void ChooseAndCheckForWinner(string playerGuess)
        {
            var computerGuess = ComputerGuess();
            if (playerGuess == computerGuess)
            {
                Console.WriteLine($"You: {ConvertGuessToWord(playerGuess)}, Computer: {ConvertGuessToWord(computerGuess)} = Tie");
                _ties ++;
            }
            else if ((playerGuess == "r" && computerGuess == "s")||(playerGuess == "p" && computerGuess == "r")||(playerGuess == "s" && computerGuess == "p"))
            {
                Console.WriteLine($"You: {ConvertGuessToWord(playerGuess)}, Computer: {ConvertGuessToWord(computerGuess)} = You Win!");
                _wins ++;
            }
            else
            {
                Console.WriteLine($"You: {ConvertGuessToWord(playerGuess)}, Computer: {ConvertGuessToWord(computerGuess)} = You Lose!");
                _losses ++;
            }
        }

        private string ComputerGuess()
        {
            var guess = _rng.Next(1, 4);
            switch (guess)
            {
                case 1:
                    return "r";
                case 2:
                    return "p";
                case 3:
                    return "s";
                default:
                    return null;
            }
        }

        private string ConvertGuessToWord(string input)
        {
            switch (input)
            {
                case "r":
                    return "Rock";
                case "p":
                    return "Paper";
                case "s":
                    return "Scissors";
                default:
                    return null;
            }
        }

        private string PromptPlayer()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter (R)ock, (P)aper, (S)cissors or (Q)uit: ");
                var userInput = Console.ReadLine()?.ToLower();

                if (userInput == "r" || userInput == "p" || userInput == "s" || userInput == "q")
                    return userInput;
            }
        }
    }
}