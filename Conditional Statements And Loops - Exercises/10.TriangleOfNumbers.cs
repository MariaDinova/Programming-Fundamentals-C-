using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;

            for (int row = 0; row < n; row++)
            {
                for (int i = 0; i < row; i++)
                {
                    Console.Write("{0} ", num);

                }
                Console.WriteLine("{0}", num);
                num++;
            }
        }
    }
}
