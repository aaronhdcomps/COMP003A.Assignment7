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
            Console.Write("Please enter a letter: ");
            char characterInput = Convert.ToChar(Console.ReadLine());
            Console.Write("Please enter a word: ");
            string word = Console.ReadLine();
            CharacterCounter(characterInput, word);
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

        static void CharacterCounter(char characterInput, string word)
        {
            int counter = 0;
            int letterCount = 0;
            foreach(char c in word)
            {
                char compare = word[counter];
                if(compare == characterInput)
                {
                    letterCount++;
                    counter++;
                }
                else
                {
                    counter++;
                }
                 
            }

            Console.WriteLine($"The letter \'{characterInput}\' appears {letterCount} times in the word {word}");
        }
    }
}