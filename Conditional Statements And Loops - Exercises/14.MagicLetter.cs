using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstletter = char.Parse(Console.ReadLine());
            char secondletter = char.Parse(Console.ReadLine());
            char ignorletter = char.Parse(Console.ReadLine());



            for (char letter1 = firstletter; letter1 <= secondletter; letter1++)
            {
                for (char letter2 = firstletter; letter2 <= secondletter; letter2++)
                {
                    for (char letter3 = firstletter; letter3 <= secondletter; letter3++)
                    {

                        if (letter1 == ignorletter || letter2 == ignorletter || letter3 == ignorletter)
                        {
                            continue;
                        }
                        Console.Write("{0}{1}{2} ", letter1, letter2, letter3);

                    }

                }

            }
        }
    }
}
