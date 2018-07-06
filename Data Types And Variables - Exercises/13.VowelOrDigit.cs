using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine().ToLower());

            bool digit = "0123456789".IndexOf(ch1) >= 0;
            bool volue = "aeuyio".IndexOf(ch1) >= 0;

            if (digit)
            {
                Console.WriteLine("digit");
            }
            else if (volue)
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
