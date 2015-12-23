/*
Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. 

Examples:

n	 randomized numbers 1…n
3	 2 1 3
10	 3 4 8 2 6 7 9 1 10 5 

Note that the above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        List<int> shuffledNumbers = new List<int>();
        Random rnd = new Random();
        int index = 0;

        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }

        for (int i = n; i > 0; i--)
        {
            index = rnd.Next(0, i);
            shuffledNumbers.Add(numbers[index]);
            numbers.RemoveAt(index);
        }

        foreach (var number in shuffledNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
