/*  Twisted Fate loves to play with cards! His favourite one is Ace of Diamonds. Your task is to draw Ace of Diamonds on the conole by given width/height. See examples below to understand the task better.

Input
The input data should be read from the console. It consists of one input value:
•	On the only input line you will recieve width/height of the card.
The input data will always be valid and in the format described. There is no need to check it explicitly.

Output
The Ace of Diamonds must be printed on the console. 

Constraints
•	The number will be odd integer number in range [3... 4,294,967,295].
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.

Examples
		
Input	Output	                             	
3    	***
        *@*
        ***		
        
Input   Output     
5	    *****
        *-@-*
        *@@@*
        *-@-*
        *****
        
Input   Output        
7	    *******
        *--@--*
        *-@@@-*
        *@@@@@*
        *-@@@-*
        *--@--*
        *******
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AceOfDiamonds
{
    class AceOfDiamonds
    {
        static void Main(string[] args)
        {
            int widthHeight = int.Parse(Console.ReadLine());
            string row = string.Empty;

            row = new string('*', widthHeight);
            Console.WriteLine(row);

            for (int i = 1; i < widthHeight / 2; i++)
            {
                row = new string('*', 1) + new string('-' ,(widthHeight / 2) - i) + new string('@', (2 * i) - 1) + new string('-', (widthHeight / 2) - i) + new string('*', 1);
                Console.WriteLine(row);
            }

            row = new string('*', 1) + new string('@', widthHeight - 2) + new string('*', 1);
            Console.WriteLine(row);

            for (int i = 1, j = 4; i < (widthHeight / 2); i++, j += 2)
            {
                row = new string('*', 1) + new string('-', i) + new string('@', widthHeight - j) + new string('-', i) + new string('*', 1);
                Console.WriteLine(row);
            }

            row = new string('*', widthHeight);
            Console.WriteLine(row);
        }
    }
}
