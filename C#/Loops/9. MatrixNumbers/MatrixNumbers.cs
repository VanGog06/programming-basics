﻿/*
Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops. 

Examples:

n	matrix
2	1 2
2   3

n	matrix
3	1 2 3
    2 3 4
    3 4 5

n	matrix
4	1 2 3 4
    2 3 4 5
    3 4 5 6
    4 5 6 7
*/

using System;

class MatrixNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write(i + j);
            }
            Console.WriteLine();
        }
    }
}
