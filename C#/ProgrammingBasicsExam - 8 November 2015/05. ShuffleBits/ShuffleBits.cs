/*
You’re given two 32-bit numbers. If the first number is larger or equal take the 1st bit from left to right, then take the 1st bit from the second number, then the 2nd bit from the first number, then the 2nd bit from the second number and so on, until you fill one 64-bit number.
If the second number is larger take the first 2 bits from the first number, then the first 2 bits from the second number and so on.
See the examples for more clarity.

Input

The input data should be read from the console. It will consist of 2 lines with an integer number on each of them.
The input data will always be valid and in the format described. There is no need to check it explicitly.

Output

The output data should be printed on the console. It will consist of only one positive integer – the result from the shuffled numbers.

Constraints

•	Each of the two input numbers will be a valid integer in the range [0... 4294967295]
•	Allowed working time: 0.1 seconds.
•	Allowed memory: 16 MB.

Examples

Input     Output        Comments
321       144711        321 -> 00000000000000000000000101000001
123                     123 -> 00000000000000000000000001111011
                        First is bigger.
                        Result –> 0000000000000000000000000000000000000000000000100011010101000111

Input     Output        Comments
123       89229         123 –> 00000000000000000000000001111011
321                     321 –> 00000000000000000000000101000001
                        Second is bigger.
                        Result –> 0000000000000000000000000000000000000000000000010101110010001101
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ShuffleBits
{
    class ShuffleBits
    {
        static void Main(string[] args)
        {
            uint firstNumber = uint.Parse(Console.ReadLine());
            uint secondNumber = uint.Parse(Console.ReadLine());
            ulong finalNumber = 0;

            if (firstNumber >= secondNumber)
            {
                for (int i = 31; i >= 0; i--)
                {
                    finalNumber = (finalNumber << 1) | ((firstNumber >> i) & 1);
                    finalNumber = (finalNumber << 1) | ((secondNumber >> i) & 1);
                }
            }
            else
            {
                for (int i = 31; i >= 0; i -= 2)
                {
                    finalNumber = (finalNumber << 1) | ((firstNumber >> i) & 1);
                    finalNumber = (finalNumber << 1) | ((firstNumber >> i - 1) & 1);
                    finalNumber = (finalNumber << 1) | ((secondNumber >> i) & 1);
                    finalNumber = (finalNumber << 1) | ((secondNumber >> i - 1) & 1);
                }
            }
            Console.WriteLine(finalNumber);
        }
    }
}