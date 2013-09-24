using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem9
{
    public class Program
    {
        public static void Main(string[] args)
         {

             int a, b, c = 0;

                for (c = 5; c < 1000; c++)
                {
                    for (b = 4; b < c; b++)
                    {
                        for (a = 3; a < b; a++)

                         {
                            if ((a * a) + (b * b) == (c * c))
                            {

                                if((a+b+c) == 1000)
                                {
                                    Console.WriteLine("a is {0}\nb is {1}\nc is {2}", a, b, c);
                                     Console.WriteLine("a*b*c = {0}", a*b*c);
                                    break;
                                }

                            }
                         }
                    }
                }

        }
    }
}
