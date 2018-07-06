using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            int num1 = Convert.ToInt32(str1, 16);

            Console.WriteLine(num1);
        }
    }
}
