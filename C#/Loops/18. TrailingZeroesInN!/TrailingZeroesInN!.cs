﻿/*
Write a program that calculates with how many zeroes the factorial of a given number n has at its end. Your program should work well for very big numbers, e.g. n=100000. 

Examples:

n	       trailing zeroes of n!	explaination
10	       2	                    3628800
20	       4	                    2432902008176640000
100000	   24999	                think why
*/

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = new BigInteger(1);
        int zeroes = 0;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        while (factorial % 10 == 0)
        {
            zeroes++;
            factorial /= 10;
        }

        Console.WriteLine(zeroes);
    }
}
