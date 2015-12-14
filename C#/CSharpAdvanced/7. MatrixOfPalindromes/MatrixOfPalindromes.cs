/*
Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:

Input	Output

3  6	aaa aba aca	ada aea afa
        bbb bcb bdb	beb bfb bgb
        ccc cec cdc	cfc cgc chc

2  3	aaa aba aca
        bbb bcb bdb

1  1	aaa

1  3	aaa aba aca
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("{0}{1}{0} ", Convert.ToChar('a' + i), Convert.ToChar('a' + j + i));
                }
                Console.WriteLine();
            }
        }
    }
}
