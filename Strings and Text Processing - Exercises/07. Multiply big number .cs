using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }

            input = input.PadLeft(input.Length + 1, '0');

            int[] number = input.Select(x => int.Parse(x.ToString())).ToArray();

            int[] sum = new int[number.Length];

            int carry = 0;

            for (int i = sum.Length - 1; i >= 0; i--)
            {
                int total = number[i] * num + carry;

                sum[i] = total % 10;

                if (total > 9)
                {
                    carry = total / 10;
                }
                else
                {
                    carry = 0;
                }
            }
            Console.WriteLine(string.Join("", sum.SkipWhile(x => x == 0)));
        }
    }
}
