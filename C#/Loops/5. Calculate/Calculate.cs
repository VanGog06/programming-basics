﻿/*
Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. Print the result with 5 digits after the decimal point.

n   x    s
3   2    2.75000
4   3    2.07407
5   -4   0.75781
*/

using System;

class Calculate
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        int currentFact = 1;
        double sum = 1.0;

        for (int i = 1; i <= n; i++)
        {
            currentFact *= i;
            sum += (double)(currentFact / Math.Pow(x, i));
        }

        Console.WriteLine("{0:F5}", sum);
    }
}
