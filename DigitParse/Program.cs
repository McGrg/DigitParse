﻿using System;
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
            Console.WriteLine($"This tens: {tens}");
            string tensString = null;
            string handredsString = null;
            string thouthandsString = null;
            tensString = tensStringParse(tens);

            Console.WriteLine($"This tensString: {tensString}");
            Console.WriteLine(digitstart);

            digitstart = (digitstart - tens) / 100;
            double hundreds = digitstart % 10;

            handredsString = handredsStringParse(hundreds) + " " + tensString;
            Console.WriteLine($"This tensString: {handredsString}");

            digitstart = (digitstart - hundreds) / 10;
            double thouthands = digitstart % 10;
            thouthandsString = thouthandsWord(thouthands) + " " + handredsString;
            Console.WriteLine(thouthandsString);
            Console.ReadKey();
        }

        static string onesStringParse(double toParse)
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
        static string tensStringParse(double toParse)
        {
            string stringResult = null;
            string stringTenthResult = null;
            string stringOnesResult = null;
            if (toParse < 10)
                stringResult = onesStringParse(toParse);
            else
                if (toParse < 20)
            {
                switch (toParse)
                {
                    case 10:
                        stringResult = "десять";
                        break;
                    case 11:
                        stringResult = "одинадцать";
                        break;
                    case 12:
                        stringResult = "двенадцать";
                        break;
                    case 13:
                        stringResult = "тринадцать";
                        break;
                    case 14:
                        stringResult = "четырнадцать";
                        break;
                    case 15:
                        stringResult = "пятнадцать";
                        break;
                    case 16:
                        stringResult = "шестнадцать";
                        break;
                    case 17:
                        stringResult = "семнадцать";
                        break;
                    case 18:
                        stringResult = "восемнадцать";
                        break;
                    case 19:
                        stringResult = "девятнадцать";
                        break;
                    case 20:
                        stringResult = "двадцать";
                        break;
                    default:
                        stringResult = null;
                        break;
                }
            }
            else
            {
                double ones = toParse % 10;
                double tens = (toParse - ones);
                stringOnesResult = onesStringParse(ones);
                switch (tens)
                {
                    case 20:
                        stringTenthResult = "двадцать";
                        break;
                    case 30:
                        stringTenthResult = "тридцать";
                        break;
                    case 40:
                        stringTenthResult = "сорок";
                        break;
                    case 50:
                        stringTenthResult = "пятьдесят";
                        break;
                    case 60:
                        stringTenthResult = "шестьдесят";
                        break;
                    case 70:
                        stringTenthResult = "семьдесят";
                        break;
                    case 80:
                        stringTenthResult = "восемьдесят";
                        break;
                    case 90:
                        stringTenthResult = "девяносто";
                        break;
                    default:
                        stringTenthResult = null;
                        break;
                }
                stringResult = stringTenthResult + " " + stringOnesResult;
            }
            return stringResult;
        }
        static string handredsStringParse(double toParse)
        {
            string stringResult = null;
            switch (toParse)
            {
                case 1:
                    stringResult = "сто";
                    break;
                case 2:
                    stringResult = "двести";
                    break;
                case 3:
                    stringResult = "триста";
                    break;
                case 4:
                    stringResult = "четыреста";
                    break;
                case 5:
                    stringResult = "пятьсот";
                    break;
                case 6:
                    stringResult = "шестьсот";
                    break;
                case 7:
                    stringResult = "семьсот";
                    break;
                case 8:
                    stringResult = "восемьсот";
                    break;
                case 9:
                    stringResult = "девятьсот";
                    break;
                default:
                    stringResult = null;
                    break;
            }
            return stringResult;
        }
        static string thouthandsWord(double toParse)
        {
            string stringResult = null;
            switch (toParse)
            {
                case 1: 
                    stringResult = "тысяча";
                    break;
                case 2:case 3: case 4:
                    stringResult = "тысячи";
                    break;
                default:
                    stringResult = "тысяч";
                    break;
            }
            return stringResult;
        }
    }
}
