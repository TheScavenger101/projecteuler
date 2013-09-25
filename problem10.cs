using System;
using System.Linq;

namespace Problem_10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long x = 2;
            long i = 0;
            bool Flag = false;
            long result = 0;
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
                    Console.Write(".");
                    result += x;
                    if (x >= 200000)
                    {
                        result = result - 0;
                        Console.WriteLine(result);
                        break;
                    }
                }
            }
        }
    }
}
