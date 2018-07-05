using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());

            int combinations = 0;
            int sum = 0;
            int mathcounter = 0;


            for (int num1 = m; num1 >= n; num1--)
            {
                for (int num2 = m; num2 >= n; num2--)
                {
                    sum = num1 + num2;
                    combinations++;
                    if (sum == control)
                    {
                        Console.WriteLine("Number found! {0} + {1} = {2}", num1, num2, sum);
                        mathcounter++;
                        return;
                    }
                }
            }
            if (mathcounter == 0)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", combinations, control);
            }

        }
    }
}
