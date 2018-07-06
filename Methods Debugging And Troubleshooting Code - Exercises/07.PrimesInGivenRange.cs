using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimesInGivenRange
{
    class Program
    {
        public static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            var primes = PrimeInList(startNum, endNum);

            Console.WriteLine(string.Join(", ", primes));
        }


        static List<int> PrimeInList(int startNum, int endNum)
        {
            var primes = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;

        }

        static bool IsPrime(long num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }
            if (num == 2)
            {
                return true;
            }
            for (int currentNum = 2; currentNum <= Math.Sqrt(num); currentNum++)
            {
                if (num % currentNum == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
