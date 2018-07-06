using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            switch (type)
            {
                case "even":
                    for (int i = 0; i < n; i++)
                    {
                        string word = Console.ReadLine();
                        if (i % 2 != 0)
                        {
                            Console.Write(word);
                            if (i != n - 1 && i != n - 2)
                            {
                                Console.Write(delimiter);
                            }
                        }
                    }
                    break;

                case "odd":
                    for (int i = 0; i < n; i++)
                    {
                        string word = Console.ReadLine();
                        if (i % 2 == 0)
                        {
                            Console.Write(word);
                            if (i != n - 1 && i != n - 2)
                            {
                                Console.Write(delimiter);
                            }
                        }
                    }
                    break;
            }
        }
    }
}
