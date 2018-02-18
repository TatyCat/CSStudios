using System;
using System.Collections.Generic;

namespace w1c2Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            Console.WriteLine("Input a string to analyze:");
            string userInput = Console.ReadLine();

            //for (int i = 0; i <userInput.Length; i++)

            //iterate through each character of input
            //if the key does not exist, add key
            //what if a key already exists?? 
            foreach (char character in userInput)
            {
                if (!char.IsLetter(character)) continue;

                if (!charCount.ContainsKey(character))
                    charCount.Add(character, 1);
         
                //if key exists
                else
                {
                    charCount[character] += 1;
                }
                
            }

            foreach(KeyValuePair<char, int> entry in charCount)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }
            
            Console.ReadLine();
        }
    }
}















/*
 Write a program that calculates the number of times each character occurs in a string and prints these counts to the console. You could get the string as input from the user, but for the sake of simplicity, you may also hard-code the string into your program as the value of a variable. 
 */
