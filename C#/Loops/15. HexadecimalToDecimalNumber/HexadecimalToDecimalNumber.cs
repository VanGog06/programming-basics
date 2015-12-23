/*
Using loops write a program that converts a hexadecimal integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. 

Examples:

hexadecimal	 decimal
FE	         254
1AE3	     6883
4ED528CBB4	 338583669684
*/

using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        long output = 0;
        long element = 0;

        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
            {
                case '1':
                    element = 1;
                    break;
                case '2':
                    element = 2;
                    break;
                case '3':
                    element = 3;
                    break;
                case '4':
                    element = 4;
                    break;
                case '5':
                    element = 5;
                    break;
                case '6':
                    element = 6;
                    break;
                case '7':
                    element = 7;
                    break;
                case '8':
                    element = 8;
                    break;
                case '9':
                    element = 9;
                    break;
                case 'A':
                    element = 10;
                    break;
                case 'B':
                    element = 11;
                    break;
                case 'C':
                    element = 12;
                    break;
                case 'D':
                    element = 13;
                    break;
                case 'E':
                    element = 14;
                    break;
                case 'F':
                    element = 15;
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }

            output += element * (long)Math.Pow(16, input.Length - 1 - i);
        }
        Console.WriteLine(output);
    }
}
