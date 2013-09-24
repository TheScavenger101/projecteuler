using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem5
{
    public class Program
    {
        public static void Main(string[] args)
         {
            bool done = false;

            int sum = 0;

            for (int i = 1; !done; i++)
            {
                sum = 0;
                for (int j = 1; j <= 20; j++)
                 {
                    if ( i % j == 0)
                    {
                        sum += 1;
                    }
                }
                if (sum == 20)
                {
                     done = true;
                    Console.WriteLine(i);
                }
            }
        }
    }
}
