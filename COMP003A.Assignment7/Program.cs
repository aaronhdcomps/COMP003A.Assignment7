/*
 * Author: Aaron Abramson
 * Course: COMP-003A 
 * Purpose: Basic Data Structures for week 7
 * 
 */

using System.Diagnostics.Metrics;

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Array - CharacterCounter");
            Console.WriteLine("Please enter a letter: ");
            char characterInput = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter a word: ");
            string word = Console.ReadLine();
            CharacterCounter(characterInput, word);
            Console.WriteLine($"The letter \'{characterInput}\' appears {LetterCount} times in the word {word}.");
        }
                
        /// <summary>
        /// Separates sections for readability
        /// </summary>
        /// <param name="sectionName">Name of section</param>
        static void SectionSeparator(string sectionName) 
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine($"\t{sectionName} Section");
            Console.WriteLine("".PadRight(50, '*'));
        }
        /// <summary>
        /// CharacterCounter method counts how many times a specified letter 
        /// appears in the specified word and outputs the number.
        /// </summary>
        /// <param name="characterInput">User provided letter</param>
        /// <param name="word">User provided word</param>
        static int CharacterCounter(char characterInput, string word)
        {
            int counter = 0;
            int letterCount = 0;
            foreach(char c in word)
            {
                char charInWord = Char.ToLower(word[counter]);
                char characterInput = Char.ToLower(characterInput);
                if (charInWord == characterInput) 
                {
                    letterCount++;
                    counter++;
                }
                else counter++;                                
            }

            return letterCount;

        }
    }
}