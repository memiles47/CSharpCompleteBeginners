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

        private void DisplayResult()
        {
            throw new System.NotImplementedException();
        }

        private void PrompUser()
        {
            throw new System.NotImplementedException();
        }

        private void DisplayPuzzle()
        {
            throw new System.NotImplementedException();
        }

        private void SetUp()
        {
            throw new System.NotImplementedException();
        }
    }
}