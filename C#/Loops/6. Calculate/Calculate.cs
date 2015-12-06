/*
Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. 

Examples:

n	k	n! / k!
5	2	60
6	5	6
8	3	6720
*/

using System;
using System.Numerics;

class Calculate
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger currentN = new BigInteger(1);
        BigInteger currentK = new BigInteger(1);

        for (int i = 1; i <= n; i++)
        {
            currentN *= i;
            if (k >= i)
            {
                currentK *= i;
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine(currentN / currentK);
    }
}
