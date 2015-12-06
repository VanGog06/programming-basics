/*
You are given n integers (given in a single line, separated by a space). Write a program that checks whether the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the first element is odd, the second is even, etc. 

Examples:

numbers	        result
2 1 1 6 3	    yes
                product = 6
3 10 4 6 5 1	yes
                product = 60
4 3 2 5 2 	    no
                odd_product = 16
                even_product = 15
*/

using System;
using System.Collections.Generic;

class OddAndEvenProduct
{
    static void Main()
    {
        string lineOfNumber = Console.ReadLine();
        int oddProduct = 1;
        int evenProduct = 1;

        string[] numbers = lineOfNumber.Split(' ');

        for (int i = 1; i <= numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenProduct *= Int32.Parse(numbers[i - 1]);
            }
            else
            {
                oddProduct *= Int32.Parse(numbers[i - 1]);
            }
        }

        if (oddProduct != evenProduct)
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddProduct);
            Console.WriteLine("even_product = {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", oddProduct);
        }
    }
}
