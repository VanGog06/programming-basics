/*
Write a program to find the longest word in a text. Examples:

Input	                                                                             Output

Welcome to the Software University.	                                                 University

The C# Basics course is awesome start in programming with C# and Visual Studio.	     programming
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.LongestWordInAText
{
    class LongestWordInAText
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(new[] { ' ', ',', '.', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string currentInput = string.Empty;
            string longestInput = inputArray[0];

            for (int i = 0; i < inputArray.Length; i++)
            {
                currentInput = inputArray[i];
                if (currentInput.Length > longestInput.Length)
                {
                    longestInput = inputArray[i];
                }
            }

            Console.WriteLine(longestInput);
        }
    }
}
