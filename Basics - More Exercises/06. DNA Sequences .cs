using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int count = 0;

            for (int firstletter = 1; firstletter <= 4; firstletter++)
            {
                for (int secondletter = 1; secondletter <= 4; secondletter++)
                {
                    for (int thirdletter = 1; thirdletter <= 4; thirdletter++)
                    {
                        count++;
                        if (firstletter + secondletter + thirdletter >= sum)
                        {
                            Console.Write("O" + ("" + firstletter + secondletter + thirdletter).
                                             Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').
                                        Replace('4', 'T') + "O ");
                        }
                        else
                        {
                            Console.Write("X" + ("" + firstletter + secondletter + thirdletter).
                        Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "X ");
                        }
                        if (count % 4 == 0)
                        {
                            Console.WriteLine();
                        }

                    }
                }
            }
        }
    }
}
