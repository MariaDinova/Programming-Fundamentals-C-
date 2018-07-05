using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var times = int.Parse(Console.ReadLine());

            if (times <= 10)
            {
                do
                {
                    Console.WriteLine($"{n} X {times} = {n * times}");
                    times++;
                }
                while (times <= 10);
            }
            else
            {
                Console.WriteLine($"{n} X {times} = {n * times}");
            }
        }
    }
}
