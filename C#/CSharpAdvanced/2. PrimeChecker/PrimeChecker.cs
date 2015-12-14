/*
Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. Examples:
n	             IsPrime(n)
0	             false
1	             false
2	             true
3	             true
4	             false
5	             true
323	             false
337	             true
6737626471	     true
117342557809	 false
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PrimeChecker
{
    class PrimeChecker
    {
        static bool isPrime(long n)
        {
            if (n == 0 || n == 1) return false;
            else if (n < 0) return false;
            else
            {
                for (int i = 2; i <= Convert.ToInt64(Math.Sqrt(n)); i++)
                {
                    if (n % i != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            bool prime = isPrime(n);

            if (!prime)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
        }
    }
}
