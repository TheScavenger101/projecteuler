using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long lettercount = 0;

            for (int i = 1; i <= 1000; i++)
            {
                lettercount += getLetterCount(i);
            }

            Console.WriteLine(lettercount);
            Console.ReadLine();
        }
        static long getLetterCount(int number)
        {
            long lettercount = 0;
            string[] digit = new string[10] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] ten = new string[10] { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };

            if (number == 1000)
            {
                lettercount += "onethousand".Length;
                return lettercount;
            }

            int tenths = number % 100;
            string letters = "";
            if (number >= 100)
            {
                letters += digit[number / 100];
                letters += "hundred";
                if (tenths != 0)
                {
                    letters += "and";
                }
            }
            if (tenths < 10)
            {
                letters += digit[tenths];
            }
            else if (tenths < 20)
            {
                switch (tenths)
                {
                    case 10:
                        letters += "ten";
                        break;
                    case 11:
                        letters += "eleven";
                        break;
                    case 12:
                        letters += "twelve";
                        break;
                    case 13:
                        letters += "thirteen";
                        break;
                    case 14:
                        letters += "fourteen";
                        break;
                    case 15:
                        letters += "fifteen";
                        break;
                    case 16:
                        letters += "sixteen";
                        break;
                    case 17:
                        letters += "seventeen";
                        break;
                    case 18:
                        letters += "eighteen";
                        break;
                    case 19:
                        letters += "nineteen";
                        break;
                }
            }
            else
            {
                letters += ten[tenths / 10];
                letters += digit[tenths % 10];
            }

            lettercount = letters.Length;
            return lettercount;
        }

    }
}
