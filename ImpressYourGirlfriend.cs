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
