using System;
using System.Collections.Generic;
using System.Linq;

namespace WordUnscrambler
{
	class MainClass
	{
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
					Console.WriteLine("Do you want to continue [Y(yes) / N(no)] ? ");
					continueDecision = Console.ReadLine() ?? string.Empty;
				} while (
					!continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) &&
					!continueDecision.Equals("N", StringComparison.OrdinalIgnoreCase));

				continueWordUnsramble = continueDecision.Equals("N", StringComparison.OrdinalIgnoreCase);
			} while (continueWordUnsramble);
		}

		private static void ExecuteScrambledWordsManualEntryScenario()
		{
		}

		private static void ExecuteScrambledWordsInFileScenario()
		{
		}
	}
}