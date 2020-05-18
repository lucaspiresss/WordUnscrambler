# WordUnscrambler
This is a simple word unscrambler in C#.

## Description
This project unscrambles a given word based on a previous loaded words list.

## How it works
1. Before running project, it is necessary to update the list of known words
   - This list can be found in `/bin/Debug/netcoreapp3.0/wordList.txt`
1. Once the list of known words is completed, the application is ready to be started
1. Application asks user to enter input option: manual / by file
   - If user choose to input scrambled words by file, the application will ask filename (this file must be in directory `/bin/Debug/netcoreapp3.0/`. This option allows user to unscramble many words simultaneously.
   - If user choose to input scrambled words manually, the application will ask the word. This option only allows user to unscramble one word at time.
1. Application unscrambles user input and shows found matches (if they exist)
1. Application asks if user want to continue or finish
