using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (Math.Abs(a - b) < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int n1 = a; n1 <= b; n1++)
                {
                    for (int n2 = a; n2 <= b; n2++)
                    {
                        for (int n3 = a; n3 <= b; n3++)
                        {
                            for (int n4 = a; n4 <= b; n4++)
                            {
                                for (int n5 = a; n5 <= b; n5++)
                                {
                                    if (n2 <= n1 || n3 <= n2 || n4 <= n3 || n5 <= n4) continue;

                                    else
                                    {
                                        Console.Write(n1 + " ");
                                        Console.Write(n2 + " ");
                                        Console.Write(n3 + " ");
                                        Console.Write(n4 + " ");
                                        Console.WriteLine(n5);
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
