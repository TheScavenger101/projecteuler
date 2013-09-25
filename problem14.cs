using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int test;
            int sum;
            int largest = 0;
            int result = 0;
            for (int j = 1000000; j >= 1; j--)
            {
                sum = 0;
                test = j;
                for (int i = 1; i > 0; i++)
                {
                    if (test % 2 == 0)
                    {
                      test = test / 2;
                    } else {
                      test = test * 3 + 1;
                    }
                    sum = i;
                    if (test == 1)
                    {
                      break;
                    }
                }
                if (sum > largest)
                {
                    largest = sum;
                    result = j;
                }
            }
            Console.WriteLine((largest) + " is the largest sequence" + " and " + " and it's found in " + (result));
        }
    }
}
