using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            long priceSbyte = 0;
            long priceInt = 0;

            long num = long.Parse(Console.ReadLine());
            long num1 = long.Parse(Console.ReadLine());

            if (num > num1)
            {
                priceInt = num;
                priceSbyte = num1;
            }
            else
            {
                priceInt = num1;
                priceSbyte = num;
            }
            long moneyNeed = (int)priceSbyte * 4 + priceInt * 10;

            Console.WriteLine(moneyNeed);
        }
    }
}
