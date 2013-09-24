using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem6
{
    public class Program
    {
        public static void Main(string[] args)
         {
            int[] a = new int[101];
            int aStored = 0;
            int aResult = 0;

            int[] b = new int[101];
            int bStored = 0;
            int bResult = 0;

            for (int x = 0; x &lt;= 100; x++)
            {
                aStored = x;
                a[x] = x * aStored;
            }

            for (int y = 0; y &lt;= 100; y++)
             {
                b[y] = y;
            }
            bStored = b.Sum();
            bResult = bStored * bStored;            
            aResult = a.Sum();            
            Console.WriteLine(bResult - aResult);
        }
    }
}
