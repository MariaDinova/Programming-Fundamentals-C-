using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            int newa = b;
            int newb = a;

            Console.WriteLine("Before:\na = {0}\nb = {1}", a, b);
            Console.WriteLine("After:\na = {0}\nb = {1}", newa, newb);
        }
    }
}
