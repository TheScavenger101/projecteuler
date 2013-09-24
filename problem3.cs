using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long product = 600851475143;
            int squareRoot = (int)Math.Sqrt(product);
            bool primeFactor = true;

            for (int i = 1; i < squareRoot; i++)
            {
                if (product % i == 0)
                {
                    primeFactor = true;
                    for (int j = (int)Math.Sqrt(i); j > 1; j--)
                    {
                        if (i % j == 0)
                        {
                            primeFactor = false;
                        }
                    }
                    if (primeFactor == true)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
