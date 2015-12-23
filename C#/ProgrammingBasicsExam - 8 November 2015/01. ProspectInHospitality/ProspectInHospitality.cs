/*
Bai Shura from Blagoevgrad was once very good at chemistry and physics. Winning every single contest and being so ambitious, he decided to go abroad in a top university to develop his skills in something a bit different from what he had studied before. Surprisingly or not, he got accepted in the MIH (Massachusetts Institute of Hospitality) in the USA with full scholarship. Getting advantage from his previously acquired knowledge he managed to finish in the top 10 students at the university.
When Shura got back to Bulgaria, the world-famous investor Adem James saw a good opportunity in him.  Mr. James decided to invest a big amount of money in making Bai Shura a big hotel owner in Bulgaria. The only thing the young lad had to do was to introduce an exhaustive project plan with the amount of money and staff needed to the investor. You are one of Bai Shura’s close friends and the main programmer of the hotel and not surprisingly you’ll be awarded some big amount of money to do your task. 
Bai Shura told you that he needs exactly ‘b’ builders, ‘r’ receptionists, ‘c’ chambermaids, ‘t’ technicians and ‘o’ others (managers, restaurant staff, security guards, piccolo, etc.). He also provided you with this table with the salary for each group in leva:
                Group	        Amount of average salary
                Builders	    1500.04 lv.
                Receptionists	2102.10 lv.
                Chambermaids	1465.46 lv.
                Technicians	    2053.33 lv.
                Others	        3010.98 lv.
Bai Shura was very good so he knew exactly how many people were needed from every group. Suddenly, he remembered that he forgot that he needed a lawyer for all the preparations and in order to make everything legal. He thought of his old friend Niki, who finished Hawaii’s Law School amongst top students, and contacted him. Niki answered immediately and agreed on the salary of n USD (USA’s currency – US Dollars).
You’ll be given the number of members for each group, the USA currency (not necessarily the real one), Niki’s salary in USD, the budget and your salary. Your task is to help your friend and write a program that calculates the amount of money needed for salaries of all hotel’s staff members including yours and excluding Shura’s who would be awarded by Mr. James separately depending on the hotel’s further development. You should also calculate whether the amount is less or equal to the budget ‘m’. And what’s the difference between budget ‘m’ and money needed

Input

The input data should be read from the console. It consists of nine input values, each at a separate line:
•	The number b – amount of builders needed.
•	The number r – amount of receptionists needed.
•	The number c – amount of chambermaids needed.
•	The number t – amount of technicians needed.
•	The number o – amount of other staff members needed.
•	The number n – Niki’s salary in USD.
•	The number u – USA’s currency rate at the moment.
•	The number s – your salary.
•	The number m – the budget.
The input data will always be valid and in the format described. There is no need to check it explicitly.

Output

•	The output data must be printed on the console.
•	On the first output line you must print the exact amount of money needed for salaries in following format:
o	“The amount is: {amount} lv.”
•	On the second output line print:
o	If budget is enough: “YES \ Left: {money left} lv.”
o	Else: “NO \ Need more: {needed money} lv.”
•	All amounts must be in leva and rounded to two decimal places.

Constraints

•	The numbers b, r, c, t and o are integers in the range [0 ... 4 294 967 285].
•	The numbers n, u, m and s are floating-point numbers in the range [0 … 7.9 x 1028].
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.

Input                        Output                                 Comments

20                        The amount is: 111506.11 lv.              20 builders * 1500.04 lv. +
10                        YES \ Left: 1888493.89 lv.                10 receptionists * 2102.10 lv. +
8                                                                   8 chambermaids * 1465.46 lv. +
2                                                                   2 technicians * 2053.33 lv. +
4                                                                   4 others * 3010.98 lv. +
3000.06                                                             3000.06 USD * 0.87 (Niki’s salary in leva) +
0.87                                                                30000.0001 lv. (your salary) = 111506.11 lv.
30000.0001
2000000.0035                                                        Left: 2000000.0035 - 111506.11 = 1888493.89

Input                       Output

0                           The amount is: 518304.64 lv.
20                          NO \ Need more: 418303.95 lv
50
0
100
1000.5
1.89
100000.698
100000.691
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ProspectInHospitality
{
    class ProspectInHospitality
    {
        static void Main(string[] args)
        {
            uint builders = uint.Parse(Console.ReadLine());
            uint recepcionists = uint.Parse(Console.ReadLine());
            uint chambermaids = uint.Parse(Console.ReadLine());
            uint technicians = uint.Parse(Console.ReadLine());
            uint others = uint.Parse(Console.ReadLine());

            decimal nikiSalaryUSD = decimal.Parse(Console.ReadLine());
            decimal USD = decimal.Parse(Console.ReadLine());
            decimal mySalary = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            decimal totalSpendings = Convert.ToDecimal(builders * 1500.04M) +
                                     (recepcionists * 2102.1M) +
                                     (chambermaids * 1465.46M) +
                                     (technicians * 2053.33M) +
                                     (others * 3010.98M) +
                                     (nikiSalaryUSD * USD) +
                                     mySalary;

            Console.WriteLine("The amount is: {0:F2} lv.", totalSpendings);

            if (totalSpendings <= budget)
            {
                Console.WriteLine("YES \\ Left: {0:F2} lv.", budget - totalSpendings);
            }
            else
            {
                Console.WriteLine("NO \\ Need more: {0:F2} lv.", totalSpendings - budget);
            }
                
        }
    }
}
