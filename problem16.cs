using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int value = 2;
            const int exponent = 1000;
            int result = 0;
            
            BigInteger number = BigInteger.Pow(value, exponent);
            
            while (number > 0)
            {
                result += (int) (number % 10);
                number /= 10;
            }
            Console.WriteLine(result);
        }
    }
}
