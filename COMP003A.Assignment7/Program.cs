/*
 * Author: Aaron Abramson
 * Course: COMP-003A 
 * Purpose: Basic Data Structures for week 7
 * 
 */


using System.Collections.Generic;
using System.Diagnostics;

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            //Array - Character Counter Section
            SectionSeparator("Array - CharacterCounter");

            Console.WriteLine("Please enter a letter: ");//Prompt to user for letter.

            char characterInput = Convert.ToChar(Console.ReadLine());//User response stored in char 'characterInput'

            Console.WriteLine("Please enter a word: ");//Prompt to user for word.

            string word = Console.ReadLine();//User response stored in string 'word'

            //characterInput and word are passed along to CharacterCounter'
            int letterCount = CharacterCounter(characterInput, word);//Letter count is returned from method 'CharacterCounter'.


            //VVVV Output to Console VVVVVVV
            Console.WriteLine($"The letter \'{characterInput}\' appears {letterCount} times in the word \"{word}\".");
            //End of Character Counter Section

            //Array - Palindrome Section
            SectionSeparator("Array - IsPalindrome");

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
            //End of Palindrome Section


            //List additions Section
            SectionSeparator("List - Add");

            //Variables
            List<string> names = new List<string>();
            string userInput = default;
            Console.WriteLine();
            //Do While loop to prompt and add names to list until fail condition
            do 
            {
                Console.WriteLine("Please enter a name");
                names.Add(Console.ReadLine());
                Console.WriteLine("Press any key to add more or (e) to exit.");
                userInput = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

            } while (userInput != "e" && userInput != "E");//The fail condition.
            //End of Add to list Section


            //List Traversal Section
            SectionSeparator("List - Traversal");
            TraverseList(names);
            //End of Traversal Section


            //List Reverse Traversal Section
            SectionSeparator("List - Reverse Traversal");
            TraverseListReverse(names);
            //End of Reverse Traversal Section
        }
        //End of Main


                //Begin Methods section---


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


                /// <summary>
                /// Traverses List takes in the string list Names
                /// and outputs each name in the string list in order.
                /// </summary>
                /// <param name="names">Names is the list of strings</param>
                static void TraverseList(List<string> names)
                {
                    foreach (string name in names) 
                    {
                        Console.WriteLine($"{name}");
                    }
                }


                /// <summary>
                /// Traverses Reverse List takes in the string list 'names', 
                /// reverses the order of the strings in the list
                /// and outputs each name in the string list by reverse order.
                /// </summary>
                /// <param name="names">Names is the list of strings</param>
                static void TraverseListReverse(List<string> names)
                {
                    names.Reverse();

                    foreach (string name in names)
                    {
                        Console.WriteLine($"{name}");
                    }
                }
                //End Methods Section
    }
}