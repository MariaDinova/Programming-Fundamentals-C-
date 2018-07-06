using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FastPrimeChecker.Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 2; num <= n; num++)
            {
                bool isPrime = true;
                for (int chekNum = 2; chekNum <= Math.Sqrt(num); chekNum++)
                {
                    if (num % chekNum == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{num} -> {isPrime}");
            }
        }
    }
}
