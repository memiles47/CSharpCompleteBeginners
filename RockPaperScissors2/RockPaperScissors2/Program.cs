using System;

namespace RockPaperScissors2
{
    class Program
    {
        private static void Main()
        {
            var game = new Game();
            game.PlayGame();
            game.DisplayScore();
        }
    }
}
