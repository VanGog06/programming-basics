/*
Write a program that reads a list of letters and prints for each letter how many times it appears in the list. The letters should be listed in alphabetical order. Use the input and output format from the examples below. Examples:

Input	                                    Output

b b a a b	                                a -> 2
                                            b -> 3

h d h a a a s d f d a d j d s h a a	        a -> 6
                                            d -> 5
                                            f -> 1
                                            h -> 3
                                            j -> 1
                                            s -> 2
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CountOfLetters
{
    class CountOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> inputLetter = input.Split(' ').ToList();
            SortedDictionary<string, int> lettersCount = new SortedDictionary<string, int>();

            for (int i = 0; i < inputLetter.Count; i++)
            {
                if (lettersCount.ContainsKey(inputLetter[i]))
                {
                    lettersCount[inputLetter[i]] += 1;
                }
                else
                {
                    lettersCount.Add(inputLetter[i], 1);
                }
            }

            foreach (var pair in lettersCount)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
