/*
Using loops write a program that converts an integer number to its hexadecimal representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. 

Examples:

decimal	       hexadecimal
254	           FE
6883	       1AE3
338583669684   4ED528CBB4
*/

using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        string output = string.Empty;
        long element = 0;

        do
        {
            element = input % 16;
            input /= 16;

            switch (element)
            {
                case 1:
                    output += "1";
                    break;
                case 2:
                    output += "2";
                    break;
                case 3:
                    output += "3";
                    break;
                case 4:
                    output += "4";
                    break;
                case 5:
                    output += "5";
                    break;
                case 6:
                    output += "6";
                    break;
                case 7:
                    output += "7";
                    break;
                case 8:
                    output += "8";
                    break;
                case 9:
                    output += "9";
                    break;
                case 10:
                    output += "A";
                    break;
                case 11:
                    output += "B";
                    break;
                case 12:
                    output += "C";
                    break;
                case 13:
                    output += "D";
                    break;
                case 14:
                    output += "E";
                    break;
                case 15:
                    output += "F";
                    break;
            }
        } while (input != 0);

        for (int i = output.Length - 1; i >= 0; i--)
        {
            Console.Write(output[i]);
        }
        Console.WriteLine();
    }
}

