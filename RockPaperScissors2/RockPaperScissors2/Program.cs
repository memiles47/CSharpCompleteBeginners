namespace RockPaperScissors2
{
    internal class Program
    {
        private static void Main()
        {
            var game = new Game();
            game.PlayGame();
            game.DisplayScore();
        }
    }
}
