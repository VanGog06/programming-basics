/*
Write a program that reads a list of names and prints for each name how many times it appears in the list. The names should be listed in alphabetical order. Use the input and output format from the examples below. Examples:

Input	                                Output

Peter Steve Nakov Steve Alex Nakov	    Alex -> 1
                                        Nakov -> 2
                                        Peter -> 1
                                        Steve -> 2

Nakov Nakov Nakov SoftUni Nakov	        SoftUni -> 1
                                        Nakov -> 4
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CountOfNames
{
    class CountOfNames
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> names = input.Split(' ').ToList();
            SortedDictionary<string, int> countNames = new SortedDictionary<string, int>();

            for (int i = 0; i < names.Count; i++)
            {
                if (countNames.ContainsKey(names[i]))
                {
                    countNames[names[i]] += 1;
                }
                else
                {
                    countNames.Add(names[i], 1);
                }
            }

            foreach (var item in countNames)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
