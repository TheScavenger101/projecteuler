using System;

namespace Problem_14
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int number = 1000000;
            long test = 0;
            long largest = 0;
            long j;
            long result = 0;
            for (j = 2; j <= number; j++)
            {
                int sum = 1;
                test = j;
                for(int i = 1; i >= 1; i++)
                {
                    if ((test % 2) == 0)
                   {
                        test = test / 2;
                    } else {
                        test = test * 3 + 1;
                    }
                    sum++;
                    if (test == 1)
                    {
                        break;
                    }
                }
                if (sum > largest)
                {
                    largest = sum;  
                    result = j;
                }
                }

            Console.WriteLine(largest + "     " + result);
            }
        }
    }
