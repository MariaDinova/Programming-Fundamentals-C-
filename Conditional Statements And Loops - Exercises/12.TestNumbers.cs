using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());

            int moves = 0;
            int sum = 0;

            for (int num1 = n; num1 >= 1; num1--)
            {
                for (int num2 = 1; num2 <= m; num2++)
                {
                    sum += (num1 * num2) * 3;
                    moves++;

                    if (sum >= control)
                    {
                        break;
                    }
                }
                if (sum >= control)
                {
                    break;
                }
            }

            Console.WriteLine("{0} combinations", moves);
            if (sum >= control)
            {
                Console.WriteLine("Sum: " + sum + " >= " + control);
            }
            else
            {
                Console.WriteLine("Sum: {0}", sum);
            }
        }
    }
}
