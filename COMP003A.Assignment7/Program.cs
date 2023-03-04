/*
 * Author: Aaron Abramson
 * Course: COMP-003A 
 * Purpose: Basic Data Structures for week 7
 * 
 */


namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Array - CharacterCounter");

            Console.WriteLine("Please enter a letter: ");//Prompt to user for letter.
            char characterInput = Convert.ToChar(Console.ReadLine());//User response stored in char 'characterInput'

            Console.WriteLine("Please enter a word: ");//Prompt to user for word.
            string word = Console.ReadLine();//User response stored in string 'word'
            //characterInput and word are passed along to CharacterCounter'
            int letterCount = CharacterCounter(characterInput, word);//Letter count is returned from method 'CharacterCounter'.
            //Output
            //vvvvvvvv
            Console.WriteLine($"The letter \'{characterInput}\' appears {letterCount} times in the word \"{word}\".");
            
            SectionSeparator("Array - IsPalindrome Section");

            Console.WriteLine("Please enter a word: ");//Prompt to user for word.
            word = Convert.ToString(Console.ReadLine());//User response stored in string 'word'
            
            bool answer = IsPalindrome(word);//Calling Method and passing word down.
            //assigns return value to answer

            if (answer == true) //Simple if else statement if answer is true or false.
            {
                Console.WriteLine($"The word \"{word}\" IS a Palindrome.");//Answer if true.
            }
            else 
            {
                Console.WriteLine($"The word \"{word}\" IS NOT a Palindrome.");//Answer if false.
            }
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
        /// <returns>Integer number of how many times provided letter appears in specified word</returns>
         
        static int CharacterCounter(char characterInput, string word)
        {
            int counter = 0;
            int letterCount = 0;
            char inputChar = Char.ToLower(characterInput);
            foreach (char c in word)
            {
                char charInWord = Char.ToLower(word[counter]);
                if (charInWord == inputChar) 
                {
                    letterCount++;
                    counter++;
                }
                else counter++;                                
            }
            return letterCount;
        }

        /// <summary>
        /// User provides word to check is a palindrome. Method takes word and converts it to lowercase. 
        /// After word is in lowercase, foreach loop itterates over the string with the reverseCounter to
        /// start from the last index in array and concantinate each char from inputWord to reverseWord.
        /// Then if statement will check if reverseWord and inputWord match and returns true or false.
        /// </summary>
        /// <param name="word">User provided word to check as a palindrome</param>
        /// <returns>True or False</returns>
        static bool IsPalindrome(string word) 
        {
            string reverseWord = "";
            string inputWord = word.ToLower();     
            int reverseCounter = inputWord.Length - 1;
            foreach (char c in inputWord)
            {
                reverseWord += Convert.ToString(inputWord[reverseCounter]); 
                reverseCounter--;
            }

            if (reverseWord == inputWord)
            {
                return true;
            }
            else return false;
            
        }




    }
}