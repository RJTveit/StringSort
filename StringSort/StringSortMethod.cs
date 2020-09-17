using System;
using System.Collections.Generic;
using System.Text;

namespace StringSort
{
    public class StringSortMethod
    {
		public static string WordSort()//removed unused parameter
		{
            Console.WriteLine("Please enter a sentence or phrase:   ");
			string userInput = Console.ReadLine();
			string word = " ", smallWord, bigWord;
			string[] wordHolder = new string[userInput.Length];//Must be assigned a value
			int length = 0;

			userInput += " ";//cahnged to compound assignment operator

			for (int i = 0; i < userInput.Length; i++)
			{
				if (userInput[i] != ' ')
				{
					word += userInput[i];//cahnged to compound assignment operator
				}

				else
				{
					wordHolder[length] = word;
					length++;
					word = " ";
				}
			}

			smallWord = bigWord = wordHolder[0];
			
			for (int j = 0; j < wordHolder.Length; j++)
			{
				if (wordHolder[j] != null)//Added an additional if statement to ignore whitespace to avoid exception
				{
					if (smallWord.Length > wordHolder[j].Length)
					{
						smallWord = wordHolder[j];
					}

					if (bigWord.Length < wordHolder[j].Length)// had failed to add .Length 
					{
						bigWord = wordHolder[j];
					}
				}
			}

			Console.WriteLine($"The largest word is {bigWord} and the smallest is {smallWord}");
			return bigWord;
		}
	}
}
