/*
Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

output
2♣ 2♦ 2♥ 2♠
3♣ 3♦ 3♥ 3♠
…
K♣ K♦ K♥ K♠
A♣ A♦ A♥ A♠
*/

using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        for (int i = 2; i <= 14; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                switch (i)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        Console.Write(i);
                        break;
                    case 11:
                        Console.Write("J");
                        break;
                    case 12:
                        Console.Write("Q");
                        break;
                    case 13:
                        Console.Write("K");
                        break;
                    case 14:
                        Console.Write("A");
                        break;
                    default:
                        Console.WriteLine("Unknown!");
                        break;
                }

                switch (j)
                {
                    case 0:
                        Console.Write("♠");
                        break;
                    case 1:
                        Console.Write("♥");
                        break;
                    case 2:
                        Console.Write("♣");
                        break;
                    case 3:
                        Console.Write("♦");
                        break;
                    default:
                        Console.WriteLine("Unknown!");
                        break;
                }
            }
        Console.WriteLine();
        }
    }
}
