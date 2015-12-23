using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.TakeThePlaneDown
{
    class TakeThePlaneDown
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int planesNumber = int.Parse(Console.ReadLine());
            string finalResult = string.Empty;

            for (int i = 0; i < planesNumber; i++)
            {
                int planeX = int.Parse(Console.ReadLine());
                int planeY = int.Parse(Console.ReadLine());

                if ((x - planeX) * (x - planeX) + (y - planeY) * (y - planeY) < r * r )
                {
                    finalResult += "You destroyed a plane at [" + planeX + "," + planeY + "]\n";
                }
            }
            Console.WriteLine(finalResult);
        }
    }
}
