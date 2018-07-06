using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;

            int litresInTheTank = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int quantities = int.Parse(Console.ReadLine());

                if (quantities <= capacity)
                {
                    capacity -= quantities;
                    litresInTheTank += quantities;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(litresInTheTank);
        }
    }
}
