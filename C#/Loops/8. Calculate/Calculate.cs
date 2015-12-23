/*
In combinatorics, the Catalan numbers are calculated by the following formula:
  
Write a program to calculate the nth Catalan number by given n (1 < n < 100). 

Examples:

n	Catalan(n)
0	1
5	42
10	16796
15	9694845
*/

using System;
using System.Numerics;

class Calculate
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger current2N = new BigInteger(1);
        BigInteger currentN = new BigInteger(1);
        BigInteger currentN1 = new BigInteger(1);

        for (int i = 1; i <= 2 * n; i++)
        {
            current2N *= i;

            if (n > i)
            {
                currentN *= i;
            }

            if (n == i)
            {
                currentN *= i;
                currentN1 = currentN * (i + 1);
            }
        }
        Console.WriteLine(current2N / (currentN1 * currentN));
    }
}
