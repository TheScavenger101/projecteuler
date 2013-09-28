using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int length = 0;
            int triangleNumber = 0;
            bool Flag = true;
           
            while (Flag == true)
            {
                length ++;
                triangleNumber += length;
               
                if (Factors(triangleNumber) > 500)
                {
                    Console.WriteLine(triangleNumber);
                    Flag = false;
                }
            }
        }
        public static int Factors(int n)
        {
            int counter = 0;
            int k = (int) Math.Sqrt(n);
           
            for (int i = 1; i < k + 1; i++)
            {
                if (n % i == 0)
                {
                    counter ++;
                }
            }
            return 2 * counter;
            }
        }
    }
