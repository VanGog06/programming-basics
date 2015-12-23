/*
We have a report that holds dates, web site URLs and load times (in seconds) in the same format like in the examples below. Your task is to calculate the average load time for each URL. Print the URLs in the same order as they first appear in the input report. Print the output in the format given below. Use double floating-point precision. Examples:

Input	                                               Output

2014-Mar-02 11:33 http://softuni.bg 8.37725            http://softuni.bg -> 7.813625
2014-Mar-02 11:34 http://www.google.com 1.335          http://www.google.com -> 2.24875
2014-Mar-03 21:03 http://softuni.bg 7.25
2014-Mar-03 22:00 http://www.google.com 2.44
2014-Mar-03 22:01 http://www.google.com 2.45
2014-Mar-03 22:01 http://www.google.com 2.77
2014-Apr-01 02:01 http://softuni.bg 8.37725            http://softuni.bg -> 5.3695625
2014-Apr-01 02:05 http://www.nakov.com 11.622          http://www.nakov.com -> 11.3706666666667
2014-Apr-01 02:06 http://softuni.bg 4.33               http://www.google.com -> 2.21758333333333
2014-Apr-01 02:11 http://www.google.com 1.94 
2014-Apr-01 02:11 http://www.google.com 2.011
2014-Apr-01 02:12 http://www.google.com 4.882
2014-Apr-01 02:34 http://softuni.bg 4.885
2014-Apr-01 02:36 http://www.nakov.com 10.74
2014-Apr-01 02:36 http://www.nakov.com 11.75
2014-Apr-01 02:38 http://softuni.bg 3.886
2014-Apr-01 02:44 http://www.google.com 1.04
2014-Apr-01 02:48 http://www.google.com 1.4555
2014-Apr-01 02:55 http://www.google.com 1.977
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _13.AverageLoadTimeCalculator
{
    class AverageLoadTimeCalculator
    {
        static void Main(string[] args)
        {
            //The ',' separator becomes '.'
            //System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            StreamReader reader = new StreamReader("input.txt");
            string report = reader.ReadToEnd();
            string[] inputArray = report.Split(new[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, List<double>> data = new Dictionary<string, List<double>>();

            foreach (string item in inputArray)
            {
                string[] splittedItem = item.Split(' ');

                if (!data.ContainsKey(splittedItem[2]))
                {
                    data[splittedItem[2]] = new List<double>() { double.Parse(splittedItem[3]) };
                }
                else
                {
                    data[splittedItem[2]].Add(double.Parse(splittedItem[3]));
                }
            }

            foreach (var item in data)
            {
                Console.WriteLine("{0} => {1}", item.Key, item.Value.Average());
            }
        }
    }
}
