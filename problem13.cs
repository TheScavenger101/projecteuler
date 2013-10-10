using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem13
{
    public class Program
    {
        public static void Main(string[] args)
        {
              var numbers = new BigInteger[100];
        
              using (var sr = new StreamReader("pe13.txt"))
              {
                    for (int i = 0; i < 100; i++)
                    {
                          numbers[i] = BigInteger.Parse(sr.Readline());
                    }
              }
              
              BigInteger total = 0;
              
              for (int i = 0; i < 100; i++)
              {
                    total += numbers[i];
              }
              
              Console.WriteLine(total.ToString().Substring(0, 10));
        }
    }
}
