using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerFactors
{
    public static class PrimeFactors
    {
        public static List<int> Generate(int number)
        {
            var primes = new List<int>();
            int orignumber = number;
            number = Math.Abs(number);

            for (int div = 2; div <= number; div++)
            {
                while (number % div == 0)
                {
                    primes.Add(div);
                    number = number / div;
                }
            }
            if ((orignumber == 1) || (orignumber == 0) || (orignumber == -1))
            {
                primes.Add(orignumber);
            }
            else if (orignumber < 0)
            {
                var primes2 = new List<int>();
                primes2.Add(-1);
                foreach (int factornumber in primes)
                {
                    primes2.Add(factornumber);
                }
                return primes2;
            }
            else if (primes.Count == 1)
            {
                var primes2 = new List<int>();
                primes2.Add(1);
                primes2.Add(orignumber);
                return primes2;
                
            }



            return primes;
        }
    }
}
