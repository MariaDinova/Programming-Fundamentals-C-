using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var countspace1 = 0;
            var countspace2 = n - 2;


            for (int i = 1; i <= (n - 1) / 2; i++)
            {
                int countx = 1;
                Console.WriteLine("{0}{1}{2}{3}{4}", new string(' ', countspace1), new string('x', countx),
                                  new string(' ', countspace2),
                                  new string('x', countx), new string(' ', countspace1));
                countspace1++;
                countspace2 = countspace2 - 2;
            }
            Console.WriteLine("{0}{1}{2}", new string(' ', (n - 1) / 2), new string('x', 1),
                                  new string(' ', (n - 1) / 2));

            int countsp1 = (n - 3) / 2;
            int countsp2 = 1;
            for (int i = (n - 1) / 2; i > 0; i--)
            {

                Console.WriteLine("{0}{1}{2}{3}{4}", new string(' ', countsp1), new string('x', 1),
                                  new string(' ', countsp2),
                                  new string('x', 1), new string(' ', countsp1));
                countsp1--;
                countsp2 = countsp2 + 2;
            }
        }
    }
}
