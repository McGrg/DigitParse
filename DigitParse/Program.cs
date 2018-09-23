using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string text=Console.ReadLine();
            Console.WriteLine($"This isdigit: {text}");
            Console.ReadKey();
            double digit = double.Parse(text);
            double digitstart = Math.Truncate(digit);
            double tenth = Math.Round(digit % digitstart, 2);
            Console.WriteLine("{0} and {1}", digitstart, tenth);
            double one = digitstart % 10;
            Console.WriteLine($"This ones: {one}");

            Console.ReadKey();
        }
    }
}
