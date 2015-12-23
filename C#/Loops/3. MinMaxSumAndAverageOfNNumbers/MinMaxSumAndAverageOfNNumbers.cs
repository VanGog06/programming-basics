/*
Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. The output is like in the examples below. 

Examples:

input	output
3       min = 1
2       max = 5
5       sum = 8
1	    avg = 2.67

input   output
2       min = -1
-1      max = 4
4       sum = 3
        avg = 1.50

*/

using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }

            sum += number;
        }

        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", (double)sum / (double)n);
    }
}

