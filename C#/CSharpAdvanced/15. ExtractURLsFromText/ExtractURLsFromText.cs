/*
Write a program that extracts and prints all URLs from given text. URL can be in only two formats:
•	http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
•	www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com

Examples:

Input	                                                         Output

The site nakov.com can be access from http://nakov.com or        http://nakov.com
www.nakov.com. It has subdomains like mail.nakov.com and         www.nakov.com
svetlin.nakov.com. Please check http://blog.nakov.com for        http://blog.nakov.com
more information.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ExtractURLsFromText
{
    class ExtractURLsFromText
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            string currentElement = string.Empty;

            for (int i = 0; i < inputArray.Length; i++)
            {
                currentElement = inputArray[i];

                if ((currentElement.StartsWith("http://")) || (currentElement.StartsWith("www.")))
                {
                    if (currentElement.EndsWith("."))
                    {
                        currentElement = currentElement.Remove(currentElement.Length - 1);
                    }
                    Console.WriteLine(currentElement);
                }
            }
        }
    }
}
