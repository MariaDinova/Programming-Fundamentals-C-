using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var hex = Convert.ToString(num, 16).ToUpper();
            var byn = Convert.ToString(num, 2);

            Console.WriteLine(hex);
            Console.WriteLine(byn);
        }
    }
}
