/*
Using loops write a program that converts a binary integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. 

Examples:

binary	                         decimal
0	                             0
11	                             3
1010101010101011	             43691
1110000110000101100101000000	 236476736
*/

using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        long output = 0;

        if ((input[input.Length - 1]) - '0' == 1)
        {
            output = 1;
        }

        for (int i = 0; i < input.Length - 1; i++)
        { 
            output += ((input[i] - '0') * (long)Math.Pow(2, input.Length - 1 - i));
        }
        Console.WriteLine(output);
    }
}
