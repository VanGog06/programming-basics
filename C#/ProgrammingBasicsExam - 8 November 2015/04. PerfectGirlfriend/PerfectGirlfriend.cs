/*
Ivan is a really handsome guy and a promising C# developer, but his communication skills and intuition are quite poor and he often experiences difficulties getting on well with his girlfriends. Every day when he meets a pretty girl at the bar he always hopes she’s the perfect one, but after a few dates he gets disappointed because she doesn’t meet his expectations, or he doesn’t meet hers.
Ivan believes that numbers have special meaning and he decided to write a program that will take some input data, make some strange calculations and depending on the result will confirm if the girl he met is perfect for him or not. He decided to use the following information: the day of the week when he met the girl, her telephone number, the size of her bra (don’t ask how he gets this information :)) and her name.
At this point, some of you might think that only the size of the bra will be enough to make precise calculations and confirm if a girl is perfect or not, but it is not so simple. Girls are really very smart and complicated and so is Ivan’s program. Help him write the program and guess which girl is the perfect one.
You will start receiving pieces of information in the following format:
[{day of the week}\{telephone number}\{size of bra}\{girl name}] until you receive the command “Enough dates!” 
The first element of the input line will hold the day of the week: Monday through Sunday. Every day will correspond to a digit from 1 to 7. If the day is Monday, you get 1, Tuesday -> 2, Wednesday -> 3, Thursday -> 4, Friday -> 5, Saturday ->6 and Sunday -> 7, respectively.
The second element will hold the girl’s telephone number. You have to sum all the digits from the number and the result to the digit corresponding to the day of the week.
The third element from the input line is the bra size. It consists of a number and a capital letter. You have to take the number and multiply it by the ASCII code of the letter then add the result to the sum you received up to now. 
The last element is the girl’s name. We take the ASCII code of the first letter and multiply it by the total length of her name, then subtract it from the result.
If the result you received so far is equal or greater than 6000, we print on the console “[name] is perfect for you.” where name should hold the girl’s name. Otherwise, print “Keep searching, [name] is not for you.” After receiving the command “Enough dates!” on the last line you have to print the total number of girls that are perfect for Ivan. Check out the example below for more clarity.
For example, you receive the following line: “Wednesday\0896123456\85B\Lilly”. The digit, corresponding to Wednesday is 3. We add it to the sum of all the digits of the telephone number (0 + 8 + 9 + 6 + 1 + 2 + 3 + 4 + 5 + 6 = 44) and the result at this point is 47. Then we take the bra size 85 and multiply by the ASCII code of ‘B’(66) and the result is 85*66 = 5610, we add to it 47 and we have 5657. The first letter from the girl’s name is ‘L’(76) and the count of letters is 5, so we make the following multiplication: 76*5 = 380. Than we subtract it from the result: 5657 - 380 = 5277. 5277 is less than 6000, so we print “Keep searching, Lilly is not for you.”

Input

The input data should be read from the console. The input will contain a random number of lines. Every line will contain information in the following format [{day of week}\{telephone number}\{size of bra}\{girl name.
The input data will always be valid and in the format described. There is no need to check it explicitly.

Output

The output data should be printed on the console.
For every input line you receive you have to print “[name] is perfect for you.” or “Keep searching, [name] is not for you.” depending on the calculations, until you receive the command “Enough dates!” On the last line you should print the number of girls that are perfect for Ivan.

Constraints

•	The number of lines you will receive before the command “Enough dates!” will be between 1 and 20.
•	Telephone numbers will be ten-digit number.
•	Bra sizes will always contain numbers between 50 and 150 and a capital letter [A-Z].
•	Allowed working time: 0.1 seconds.
•	Allowed memory: 16 MB.

Input                                   Output                                          Comments
                                        
Wednesday\0896123456\85B\Lilly          Keep searching, Lilly is not for you.           Wednesday -> 3
Enough dates!                           0                                               Some of phone digits -> 0 + 8 + 9 + 6                                                                                       + 1 + 2 + 3 + 4 + 5 + 6 = 44
                                                                                        Bra size -> 85 * ‘B’(66) = 5610
                                                                                        First letter from name –> “L”(76) 
                                                                                        * 5 (name’s length) = 380
                                                                                        Result = 47 + 5610 – 380 = 5277 < 6000

Input                                   Output
   
Monday\0897656756\110B\Hrizantema       Hrizantema is perfect for you.
Sunday\0223411111\75C\Asia              Keep searching, Asia is not for you.
Enough dates!                           1
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PerfectGirlfriend
{
    class PerfectGirlfriend
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int perfectMatch = 0;

            while (input != "Enough dates!")
            {
                string[] inputString = input.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                int finalScore = 0;

                string phone = inputString[1];
                string braSize = inputString[2];
                string name = inputString[3];

                switch (inputString[0])
                {
                    case "Monday":
                        finalScore = 1;
                        break;
                    case "Tuesday":
                        finalScore = 2;
                        break;
                    case "Wednesday":
                        finalScore = 3;
                        break;
                    case "Thursday":
                        finalScore = 4;
                        break;
                    case "Friday":
                        finalScore = 5;
                        break;
                    case "Saturday":
                        finalScore = 6;
                        break;
                    case "Sunday":
                        finalScore = 7;
                        break;
                }

                foreach (var item in phone)
                {
                    finalScore += item - '0';
                }

                finalScore += Convert.ToInt32(braSize.Substring(0, braSize.Length - 1)) * 
                              Convert.ToInt32(braSize[braSize.Length - 1]);

                finalScore -= Convert.ToInt32(name[0]) * name.Length;

                if (finalScore >= 6000)
                {
                    Console.WriteLine("{0} is perfect for you.", name);
                    perfectMatch++;
                }
                else
                {
                    Console.WriteLine("Keep searching, {0} is not for you.", name);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(perfectMatch);
        }
    }
}
