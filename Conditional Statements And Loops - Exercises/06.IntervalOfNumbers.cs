using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            if (min < max)
            {
                for (int i = min; i <= max; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (min > max)
            {
                for (int i = max; i <= min; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
