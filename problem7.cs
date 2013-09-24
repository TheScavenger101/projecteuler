using System;
using System.Collections.Generic;
using System.Linq;
 using System.Text.RegularExpressions;

namespace Problem7
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = 2;
            int i = 0;
            int sum = 0;
             bool Flag = false;
            for (x = 2; x > 1; x++)
            {
                Flag = false;
                for (i = 2; i <= x / 2; i++)
                {
                    if (i == x)
                     {
                        i = i + 1;
                    }
                    if (x % i == 0)
                    {
                        Flag = true;
                        break;
                     }
                }

                if (Flag == false)
                {
                    sum += 1;
                    if (sum == 10001)
                    {
                         Console.WriteLine(x);
                    }
                }
            }
        }
    }
}
