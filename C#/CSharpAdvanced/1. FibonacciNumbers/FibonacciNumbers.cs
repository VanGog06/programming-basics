/*
Define a method Fib(n) that calculates the nth Fibonacci number. Examples:
n	Fib(n)
0	1
1	1
2	2
3	3
4	5
5	8
6	13
11	144
25	121393
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static int[] Fibonacci(int n)
        {
            int[] numbers = new int[n];
            numbers[0] = 1;
            numbers[1] = 1;

            if (n == 0 || n == 1)
            {
                return numbers;
            }

            for (int i = 2; i < n; i++)
            {
                numbers[i] = (numbers[i - 1] + numbers[i - 2]);
            }

            return numbers;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] fibonacciNumbers = Fibonacci(n);

            Console.WriteLine(fibonacciNumbers[n - 1]);
        }
    }
}
