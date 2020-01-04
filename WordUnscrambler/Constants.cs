namespace WordUnscrambler
{
    public class Constants
    {
        public const string OptionsOnHowToEnterScrambledWords = "Please enter input option [F (file) / M (manual)]: ";
        public const string OptionsOnContinuingProgram = "Do you want to continue [Y (yes) / N (no)]?";

        public const string EnterScrambledWordsViaFile = "Enter scrambled words file: ";
        public const string EnterScrambledWordsManually = "Enter scrambled words manually: ";
        public const string EnterScrambledWordsOptionNotRecognized = "Option was not recognized";

        public const string ErrorScrambledWordsCannotBeLoaded = "Scrambled words were not loaded because there was an error: ";
        public const string ErrorProgramWillBeTerminated = "The program will be terminated: ";

        public const string MatchFound = "Match found {0} : {1}";
        public const string MatchNotFound = "No matches have been found.";

        public const string Yes = "Y";
        public const string No = "N";
        public const string File = "F";
        public const string Manual = "M";

        public const string WordListFileName = "wordList.txt";
    }
}