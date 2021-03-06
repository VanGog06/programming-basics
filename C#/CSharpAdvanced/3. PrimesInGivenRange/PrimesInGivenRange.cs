﻿/*
Write a method that calculates all prime numbers in given range and returns them as list of integers:

static List<int> FindPrimesInRange(startNum, endNum)
{
    …
}

Write a method to print a list of integers. Write a program that enters two integer numbers (each at a separate line) and prints all primes in their range, separated by a comma.
Examples:

Start number        Output
End number
0                   2, 3, 5, 7
10

5                   5, 7, 11
11

100                 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199
200

250                 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373,
950                 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499,                    503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641,                    643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773,                    787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929,                    937, 941, 947

100                 (empty list)
50
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static List<int> FindPrimesInRange (int startNumber, int endNumber)
        {
            List<int> primes = new List<int>();
            bool isPrime = true;

            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i == 0 || i == 1)
                {
                    continue;
                }

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    primes.Add(i);
                }
                isPrime = true;
            }

            return primes;
        }

        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            List<int> primeNumbers = FindPrimesInRange(startNumber, endNumber);

            foreach(var prime in primeNumbers)
            {
                Console.Write(prime + " ");
            }
            Console.WriteLine();
        }
    }
}
