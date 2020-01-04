using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordUnscrambler.Workers;

namespace WordUnscrambler.Test.Unit
{
    [TestClass]
    public class WordMatcherTest
    {
        private readonly WordMatcher _wordMatcher = new WordMatcher();

        [TestMethod]
        public void ScrambledWordMatchesGivenWordInTheList()
        {
            string[] scrambledWords = { "omre" };
            string[] wordList = { "cat", "chair", "more" };

            var matchedWords = _wordMatcher.Match(scrambledWords, wordList);

            Assert.IsTrue(matchedWords.Count == 1);

            Assert.IsTrue(matchedWords[0].ScrambledWord.Equals("omre"));
            Assert.IsTrue(matchedWords[0].Word.Equals("more"));
        }

        [TestMethod]
        public void ScrambledWordMatchesGivenWordsInTheList()
        {
            string[] scrambledWords = { "omre", "act" };
            string[] wordList = { "cat", "chair", "more" };

            var matchedWords = _wordMatcher.Match(scrambledWords, wordList);

            Assert.IsTrue(matchedWords.Count == 2);

            Assert.IsTrue(matchedWords[0].ScrambledWord.Equals("omre"));
            Assert.IsTrue(matchedWords[0].Word.Equals("more"));

            Assert.IsTrue(matchedWords[1].ScrambledWord.Equals("act"));
            Assert.IsTrue(matchedWords[1].Word.Equals("cat"));
        }
    }
}