/*
Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list, and all numbers from the second list, without repeating numbers, and arranged in increasing order. The input and output lists are given as integers, separated by a space, each list at a separate line. Examples:

Input	                Output

20 40 10 10 30 80       10 20 25 30 40 80
25 20 40 30 10	

5 4 3 2 1               1 2 3 4 5 6
6 3 2	

1                       1
1	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.JoinLists
{
    class JoinLists
    {
        static void Main(string[] args)
        {
            string firstList = Console.ReadLine();
            string secondList = Console.ReadLine();

            List<int> firstNumbers = firstList.Split(' ').Select(int.Parse).ToList();
            List<int> secondNumbers = secondList.Split(' ').Select(int.Parse).ToList();

            bool isInit = false;
            
            for (int i = 0; i < firstNumbers.Count; i++)
            {
                for (int j = 0; j < secondNumbers.Count; j++)
                {
                    if (firstNumbers[i] == secondNumbers[j])
                    {
                        isInit = true;
                    }
                }

                if (!isInit)
                {
                    secondNumbers.Add(firstNumbers[i]);
                }

                isInit = false;
            }

            foreach (var item in secondNumbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
