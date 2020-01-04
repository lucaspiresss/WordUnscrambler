﻿using System;
using System.Collections.Generic;
using System.Linq;
using WordUnscrambler.Data;
using WordUnscrambler.Workers;

namespace WordUnscrambler
{
	class MainClass
	{
		private static readonly FileReader _fileReader = new FileReader();
		private static readonly WordMatcher _wordMatcher = new WordMatcher();

		public const string WordListFileName = "wordList.txt";

		public static void Main(string[] args)
		{
			bool continueWordUnsramble = true;

			do
			{
				Console.WriteLine("Please enter input option [F (file) / M (manual)]: ");
				var option = Console.ReadLine() ?? string.Empty;

				switch (option.ToUpper())
				{
					case "F":
						Console.Write("Enter scrambled words file: ");
						ExecuteScrambledWordsInFileScenario();
						break;

					case "M":
						Console.Write("Enter scrambled words manually: ");
						ExecuteScrambledWordsManualEntryScenario();
						break;

					default:
						Console.WriteLine("Option was not recognized");
						break;
				}

				var continueDecision = string.Empty;
				do
				{
					Console.WriteLine("Do you want to continue [Y(yes) / N(no)]? ");
					continueDecision = Console.ReadLine() ?? string.Empty;
				} while (
					!continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) &&
					!continueDecision.Equals("N", StringComparison.OrdinalIgnoreCase));

				continueWordUnsramble = continueDecision.Equals("N", StringComparison.OrdinalIgnoreCase);
			} while (continueWordUnsramble);
		}

		private static void ExecuteScrambledWordsManualEntryScenario()
		{
			var manualInput = Console.ReadLine() ?? string.Empty;

			string[] scrambledWords = manualInput.Split(',');

			DisplayMatchedUnscrambledWords(scrambledWords);
		}

		private static void ExecuteScrambledWordsInFileScenario()
		{
		    var fileName = Console.ReadLine() ?? string.Empty;

		    string[] scrambledWords = _fileReader.Read(fileName);

		    DisplayMatchedUnscrambledWords(scrambledWords);
		}

		private static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
		{
			string[] wordList = _fileReader.Read(WordListFileName);

			List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);

			if (matchedWords.Any())
			{
				foreach (var matchedWord in matchedWords)
				{
					Console.WriteLine("Match found {0} : {1}", matchedWord.ScrambledWord, matchedWord.Word);
				}
			}
			else
			{
				Console.WriteLine("No matches have been found");
			}
		}
	}
}