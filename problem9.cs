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
            int d = 1000;
            int res = 0;
            bool done = false;

            for (a = 1; a < d; a++)
             {
                for (b = a; b < d; b++)
                {
                    c = d - a - b;
                    if (a * a + b * b == c * c)
                    {
                        done = true;
                         break;
                    }
                }
                if (done == true)
                {
                    break;
                }
            }
                    Console.WriteLine("a = " + a);
                    Console.WriteLine("b = " + b);
                    Console.WriteLine("c = " + c);
                    Console.WriteLine("The product is: " + (a * b * c));
        }
     }
}
