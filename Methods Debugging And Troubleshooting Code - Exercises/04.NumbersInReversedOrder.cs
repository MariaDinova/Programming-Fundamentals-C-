using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        public static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            decimal reversedNum = ReversedNumDigits(num);
            Console.WriteLine(reversedNum);

        }

        private static decimal ReversedNumDigits(decimal num)
        {
            string numToString = num.ToString();
            string result = "";
            for (int i = numToString.Length - 1; i >= 0; i--)
            {
                result += numToString[i];
            }
            return decimal.Parse(result);

        }
    }
}
