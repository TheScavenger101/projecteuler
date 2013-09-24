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
            int a = 0;
            int b = 0;
            int c = 0;

            int total = 1000;

            for (a = 0; a < 1000; a++)
            {
                for (b = 0; b < 1000; b++)
                 {
                    for (c = 0; c < 1000; c++)
                    {
                        if (a < b)
                        {
                            if (b < c)
                            {
                                 if ((a * a) + (b * b) == (c * c))
                                {
                                    if (a + b + c == 1000)
                                    {
                                        Console.WriteLine(a + " " + b + " " + c);

                                        total = a * b * c;
                                        Console.WriteLine(total);
                                    }
                                }
                             }
                        }
                    }
                }
            }
        }
    }
}
