using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem2
{
    public class Program
    {
        public static void Main(string[] args)
         {
            int a = 0;
            int b = 1;
            int result = 0;
            long[] resultEven = new long[50];
            long sum = 0;

            for (int i = 2; i <= 33; i++)
             {
                result = b + a;
                a = b;
                b = result;

                if ( result % 2 == 0)
                {                    
                    resultEven[i] = result;
                 }
            }
            sum = resultEven.Sum();
            Console.WriteLine(sum);
        }
    }
}
