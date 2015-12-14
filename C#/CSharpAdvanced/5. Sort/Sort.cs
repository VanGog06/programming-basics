/*
Write a program that reads a number n and a sequence of n integers, sorts them and prints them. Examples:
Input	Output
5       -3
        0
3       2
-3      3 
2       122
122
0


3       0
        0
0       1
1
0
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Sort
{
    class Sort
    {
        static List<int> BubbleSort(List<int> numbers)
        {
            int temp = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = 1; j < numbers.Count; j++)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        temp = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            return numbers;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            List<int> sortedNumbers = BubbleSort(numbers);
            foreach (var number in sortedNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
