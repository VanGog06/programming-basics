/* 
Apocalypse is coming! Zombies raised up, but they are not ordinarily zombies. They can manage fighters.
You are governor of security of Wonderland and you need to protect your country. We assume that Wonderland territory is a complete circle and your headquarters are located exactly in the middle of the country. The zombies will try to cross your air borders and you need to take them down. You can do that only when they are over your air space.
You will be given coordinates (x,y) of your headquarters and the distance to the borders. On the next line you will receive the number of the fighters that are approaching your country. After that for the next N * 2 lanes you will be given all the planes coordinates. You need to calculate the distance to every one of them and if they are inside your country shoot them. For every plane you destroy you need to print a message for it on the console: You destroyed a plane at [x,y]. Where x and y are the coordinates of the plane.

Input
The input data should be read from the console. It consists of: 
•	On the first line you will be given the X of your headquarter.
•	On the second line you will be given the Y of your headquarter.
•	On the third line you will be given the distance from your headquarter to the borders.
•	On the fourth line you will be given the number of the planes that are approaching
On the next 2*N lines you will be given:
•	On the every odd line you will be given the plane X coordinate
•	on the every even line you will be given the plane Y coordinate 
The input data will always be valid and in the format described. There is no need to check it explicitly.

Output
The output must consist of massage for every plane that is destroyed.

Constraints
•	The coordinates of your headquarter, distance to the borders, number of the planes and planes coordinates will be integers in range [-2,147,483,648 to 2,147,483,647].
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.

Examples
Input	Output
0       You destroyed a plane at [1,0]
0
5
2
1
0
4
11	

Input	Output
10      You destroyed a plane at [10,4]
4        You destroyed a plane at [11,4]
2
3
0
0
10
4
11
4	
*/

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
