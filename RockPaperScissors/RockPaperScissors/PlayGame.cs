using System;

namespace RockPaperScissors
{
    class PlayGame
    {
        public void Rock(int computerGuess)
        {
            if (computerGuess == 1)
                Console.WriteLine("Rock -vs- Rock: Tie game");
            else if (computerGuess == 2)
                Console.WriteLine("Paper covers Rock: Computer wins!");
            else
                Console.WriteLine("Rock beats Scissors: You win!");

            Console.Write("Press enter to continue");
            Console.ReadLine();
        }

        public void Paper(int computerGuess)
        {
            if (computerGuess == 1)
                Console.WriteLine("Paper covers Rock: You win!");
            else if (computerGuess == 2)
                Console.WriteLine("Paper -vs- Paper: Tie game");
            else
                Console.WriteLine("Scisors cut Paper: Computer Wins!");

            Console.Write("Press enter to continue");
            Console.ReadLine();
        }

        public void Scissors(int computerGuess)
        {
            if (computerGuess == 1)
                Console.WriteLine("Rock beats Scissors: Computer Wins!");
            else if (computerGuess == 2)
                Console.WriteLine("Scissors cut Paper: You Win!");
            else
                Console.WriteLine("Scissors -vs- Scissors: Tie game");

            Console.Write("Press enter to continue");
            Console.ReadLine();
        }
    }
}