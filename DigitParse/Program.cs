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
            double digit = double.Parse(text);
            double digitstart = Math.Truncate(digit);
            double tenth = Math.Round(digit % digitstart, 2);
            Console.WriteLine("{0} and {1}", digitstart, tenth);
            double tens = digitstart % 100;
            Console.WriteLine($"This ones: {tens}");
            string onesString = null;
            string tensString = null;
            string handredsString = null;
            if (tens < 10)
                onesString = stringParse(tens);
            else
                if (tens < 20)
                {
                    switch (tens)
                        {
                        case 10:
                            onesString = "десять";
                            break;
                        case 11:
                            onesString = "одинадцать";
                            break;
                        case 12:
                            onesString = "двенадцать";
                            break;
                        case 13:
                            onesString = "тринадцать";
                            break;
                        case 14:
                            onesString = "четырнадцать";
                            break;
                        case 15:
                            onesString = "пятнадцать";
                            break;
                        case 16:
                            onesString = "шестнадцать";
                            break;
                        case 17:
                            onesString = "семнадцать";
                            break;
                        case 18:
                            onesString = "восемнадцать";
                            break;
                        case 19:
                            onesString = "девятнадцать";
                            break;
                        case 20:
                            onesString = "двадцать";
                            break;
                        default:
                            onesString = null;
                            break;
                    }
                }
        else 
        {
                double ones = tens % 10;
                tens = (tens - ones);
                onesString = stringParse(ones);
                switch (tens)
                {
                    case 20:
                        tensString = "двадцать";
                        break;
                    case 30:
                        tensString = "тридцать";
                        break;
                    case 40:
                        tensString = "сорок";
                        break;
                    case 50:
                        tensString = "пятьдесят";
                        break;
                    case 60:
                        tensString = "шестьдесят";
                        break;
                    case 70:
                        tensString = "семьдесят";
                        break;
                    case 80:
                        tensString = "восемдесят";
                        break;
                    case 90:
                        tensString = "девяносто";
                        break;
                    default:
                        tensString = null;
                        break;
                }
            }
            Console.WriteLine($"This tensString: {tensString}; This onesString: {onesString}");
            Console.ReadKey();
        }

        static string stringParse(double toParse)
        {
            string stringResult = null;
            switch (toParse)
            {
                case 1:
                    stringResult = "один";
                    break;
                case 2:
                    stringResult = "два";
                    break;
                case 3:
                    stringResult = "три";
                    break;
                case 4:
                    stringResult = "четыре";
                    break;
                case 5:
                    stringResult = "пять";
                    break;
                case 6:
                    stringResult = "шесть";
                    break;
                case 7:
                    stringResult = "семь";
                    break;
                case 8:
                    stringResult = "восемь";
                    break;
                case 9:
                    stringResult = "девять";
                    break;
                default:
                    stringResult = null;
                    break;
            }
            return stringResult;
        }
    }
}
