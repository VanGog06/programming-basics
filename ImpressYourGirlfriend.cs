/*  
Spiro is a big CS GO fan. He's been saving money for months to buy the new Counter Strike game. However, he has five options to buy the game from. The first one is a shady Russian site selling games in rubles (Russian currency). Another option is an American site selling games in dollars (American currency). Spiro's third option is the official site of the game - selling games in euros (European Union currency). The final 2 options are Bulgarian sites B and M. Both of them sell in leva (Bulgarian currency). B offers a very special deal - 2 copies of the game for the price of one. M sells games for normal prices. Spiro is very bad with math and can't calculate the game prices in leva. But he wants to impress his girlfriend by showing her he bought the most expensive game.
Assume that Spiro has a girlfriend, all games are identical, 100 rubles are 3.5 leva, 1 dollar is 1.5 leva, 1 euro is 1.95 leva and if Spiro buys 2 special games from B and he always sell one of them for exactly half of the money he paid for both. 
Your task is to write a program that calculates the most expensive game.

Input
The input data should be read from the console. It consists of five input values, each at a separate line:
•	The number r – amount of rubles Spiro has to pay for the game at the Russian site.
•	The number d – amount of dollars Spiro has to pay for the game at the American site.
•	The number e – amount of euro Spiro has to pay for the game at the official site.
•	The number b – amount of leva Spiro has to pay for the special offer at B.
•	The number m – amount of leva Spiro has to pay for the game at M's site.
The input data will always be valid and in the format described. There is no need to check it explicitly.

Output
•	The output data must be printed on the console. On the only output line you must print the most expensive game price rounded up to the next integer number.

Constraints
•	The numbers r, d, e, b, m are integer numbers in range [0... 4,294,967,295].
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.

Input   Output   Comments
2600    117.00   2600 rubles is 2600 / 100 = 26 * 3.5 = 91 leva, 60 dollars is 60 * 1.5 = 90 leva , 60 euro is 60 * 1.95 = 117 leva, 
60               130 leva for 2 games is 130 / 2 = 65 leva per game and 70 leva is 70 leva. The most expensive game is 117 leva.
60
130
70

Input	Output
2050    147.00
85
75
239
80	  

Input	Output
800     30.00
11
15
28
13	

Input   Output
700     25.00
5
1
20
4
*/

using System;

class LectureSeven
{
    static void Main()
    {
        uint rubbles = uint.Parse(Console.ReadLine());
        uint dollars = uint.Parse(Console.ReadLine());
        uint euro = uint.Parse(Console.ReadLine());
        uint levaB = uint.Parse(Console.ReadLine());
        uint levaM = uint.Parse(Console.ReadLine());
        double maxValue = 0.0;

        double rubblesToLevas = (double)(rubbles / 100) * 3.5;
        double dollarsToLevas = (double)dollars * 1.5;
        double euroToLevas = (double)euro * 1.95;
        double levaBOneGame = (double)levaB / 2;
        double levaMFinal = (double)levaM;

        maxValue = Math.Max(rubblesToLevas, dollarsToLevas);
        maxValue = Math.Max(maxValue, euroToLevas);
        maxValue = Math.Max(maxValue, levaBOneGame);
        maxValue = Math.Max(maxValue, levaM);

        Console.WriteLine("{0:F2}", Math.Ceiling(maxValue));
    }
}
