/*
Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. Examples:

First date            Days between
Second date	
17.03.2014            44
30.04.2014	

17.03.2014            0
17.03.2014	

14.06.1980            12317
5.03.2014	

5.03.2014             -2
3.03.2014	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main(string[] args)
        {
            string dateOne = Console.ReadLine();
            string dateTwo = Console.ReadLine();
            string format = "d.M.yyyy";
            DateTime formattedDateOne = DateTime.ParseExact(dateOne, format, System.Globalization.CultureInfo.InvariantCulture);
            DateTime formattedDateTwo = DateTime.ParseExact(dateTwo, format, System.Globalization.CultureInfo.InvariantCulture);

            TimeSpan difference = formattedDateTwo.Date - formattedDateOne.Date;
            Console.WriteLine(difference.Days);
        }
    }
}
