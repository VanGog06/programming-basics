/*
Write a program that takes as input two lists of names and removes from the first list all names given in the second list. The input and output lists are given as words, separated by a space, each list at a separate line. Examples:

Input	                                      Output

Peter Alex Maria Todor Steve Diana Steve      Peter Alex Maria Diana
Todor Steve Nakov	

Hristo Hristo Nakov Nakov Petya               Hristo Hristo Petya
Nakov Vanessa Maria	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.RemoveNames
{
    class RemoveNames
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string remove = Console.ReadLine();

            List<string> firstList = names.Split(' ').ToList();
            List<string> removeList = remove.Split(' ').ToList();
            List<string> finalList = new List<string>();

            int counter = 0;

            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = 0; j < removeList.Count; j++)
                {
                    if (firstList[i] == removeList[j])
                    {
                        counter++;
                    }
                }

                if (counter == 0)
                {
                    finalList.Add(firstList[i]);
                }
                counter = 0;
            }

            foreach (var item in finalList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
