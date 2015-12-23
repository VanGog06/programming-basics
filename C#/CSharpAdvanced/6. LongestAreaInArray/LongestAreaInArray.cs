/*
Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings (each at a separate line), then find and print the longest sequence of equal elements (first its length, then its elements). If multiple sequences have the same maximal length, print the leftmost of them. Examples:

Input           Output

6               3
hi              ok
hi              ok
hello           ok
ok
ok
ok

2               1
SoftUni         SoftUni
Hello

4               4
hi              hi
hi              hi
hi              hi
hi              hi
 
5               2
wow             hi
hi              hi
hi
ok
ok
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.LongestAreaInArray
{
    class LongestAreaInArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[n];
            int counter = 0;
            int longestSequence = 0;
            string value = String.Empty;

            for (int i = 0; i < n; i++)
            {
                input[i] = Console.ReadLine();
            }

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (longestSequence < counter)
                {
                    longestSequence = counter;
                    value = input[i];
                }

                counter = 0;
            }

            Console.WriteLine(longestSequence);
            for (int i = 0; i < longestSequence; i++)
            {
                Console.WriteLine(value);
            }
        }
    }
}
