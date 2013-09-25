using System;

namespace Problem_10
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var sieve = new bool[2000000];
            sieve[0] = true;
            sieve[1] = true;

            for (int i = 2; i < Math.Sqrt(sieve.Length); i++)
            {
                if(!sieve[i])
                {
                for (int j = i * i; j < sieve.Length; j+=i)
                {
                    sieve[j] = true;
                }
                 }
            }

            ulong sum = 0;

            for (int i = 0; i < sieve.Length; i++)
            {
                if(!sieve[i]){
                sum += (ulong)i;
                 }
            }
            Console.WriteLine(sum);
		}
	}
}
