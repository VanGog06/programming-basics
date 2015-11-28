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
