/*
Minka likes to play Sudoku. She downloaded on her phone an application so she can play anytime, anywhere, but mostly when she is in the tram going to work. She also likes statistics and wants to know her average time per game. As a young programmer your task is to modify the Sudoku app to calculate the average time per game. After each game you should get the time and when she presses the “Quit” button the application should display the average time in seconds.
Also, when the game ends, it should give a score based on the average time. The rules for the score are as follows:
•	When the average time is lower than 720 seconds - give a Gold Star
•	When the average time is between 720 and 1440 seconds – give a Silver Star
•	When the average time is higher than 1440 seconds – give a Bronze Star
Write a console application to test your modification. You’ll get the result for each game from the console, each on a new line in the format “[mm]:[ss]” until you receive the command “Quit”. Convert the sum of all results to seconds, find the average seconds and print the corresponding star and the count of the games in the following format:
•	{Gold, Silver or Bronze} Star
•	“Games – {count of games} \ Average seconds – {average seconds}”.

Input

The input data should be read from the console. On each new line you will be given a string with the time in minutes and seconds until you receive the command “Quit”. 

Output

The output should be printed on the console. It should consist of exactly 2 lines: First with received star and second with the count of the games and the average score in seconds rounded up to the nearest integer in the following format:
•	{Gold, Silver or Bronze} Star
•	“Games – {count of games} \ Average seconds – {average seconds}”.

Constraints

•	The time will always be in the format “[mm]:[ss]” with leading zeros if it’s necessary.
•	The input lines will be in the range: [1… 100].
•	The minutes will be a valid integer in the range: [00… 99].
•	The seconds will be a valid integer in the range: [00… 59]. 
•	Allowed working time for your program: 0.25 seconds. 
•	Allowed memory: 16 MB. 

Input	        Outut

10:00           Gold Star
05:00           Games - 3 \ Average seconds - 600
15:00
Quit	

Input           Output                                      Comments
    
10:00           Silver Star                                 10:00 + 19:01 = 600 + 1141 = 1741 sec
19:01           Games - 2 \ Average seconds - 871           1741 / 2 = 870.5 -> Rounded up 871
Quit	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SudokuResults
{
    class SudokuResults
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int gamesPlayed = 0;
            int totalSeconds = 0;
            string reward = string.Empty;

            while (input != "Quit")
            {
                string[] time = input.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                totalSeconds += (Convert.ToInt32(time[0]) * 60) + Convert.ToInt32(time[1]);
                gamesPlayed++;

                input = Console.ReadLine();
            }

            int averageTime =(int) Math.Ceiling((double)totalSeconds / gamesPlayed);

            if (averageTime < 720)
            {
                reward = "Gold Star";
            }
            else if (averageTime >= 720 && averageTime <= 1440)
            {
                reward = "Silver Star";
            }
            else
            {
                reward = "Bronze Star";
            }

            Console.WriteLine(reward);
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", gamesPlayed, averageTime);
        }
    }
}
