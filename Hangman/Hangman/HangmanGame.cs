namespace Hangman
{
    class HangmanGame
    {
        private bool _keepPlaying;
        private int _guessesLeft;
        private string _answer;
        private int _lettersFound;

        private string[] _guessedLetters;
        private int _guessedLettersIndex;

        private string[] _wordDisplay;

        public void Play()
        {
            SetUp();

            while (_keepPlaying)
            {
                DisplayPuzzle();
                PrompUser();
            }

            DisplayResult();
        }
    }
}