using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            double sum = 0;

            while (game != "Game Time" && balance > 0)
            {

                switch (game)
                {
                    case "OutFall 4":
                        if (balance < 39.99 && balance > 0)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Bought {0}", game);
                            balance = balance - 39.99;
                            sum = sum + 39.99;

                        }
                        break;

                    case "CS: OG":
                        if (balance < 15.99 && balance > 0)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Bought {0}", game);
                            balance = balance - 15.99;
                            sum = sum + 15.99;
                        }
                        break;

                    case "Zplinter Zell":
                        if (balance < 19.99 && balance > 0)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Bought {0}", game);
                            balance = balance - 19.99;
                            sum = sum + 19.99;
                        }
                        break;

                    case "Honored 2":
                        if (balance < 59.99 && balance > 0)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Bought {0}", game);
                            balance = balance - 59.99;
                            sum = sum + 59.99;
                        }
                        break;

                    case "RoverWatch":
                        if (balance < 29.99 && balance > 0)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Bought {0}", game);
                            balance = balance - 29.99;
                            sum = sum + 29.99;
                        }
                        break;

                    case "RoverWatch Origins Edition":
                        if (balance < 39.99 && balance > 0)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Bought {0}", game);
                            balance = balance - 39.99;
                            sum = sum + 39.99;
                        }
                        break;

                    default: Console.WriteLine("Not Found"); break;
                }
                game = Console.ReadLine();


            }
            if (balance > 0)
            {
                Console.WriteLine("Total spent: ${0:F2}. Remaining: ${1:F2}", sum, balance);
            }
            else if (balance <= 0)
            {
                Console.WriteLine("Out of money!");
            }
        }
    }
}
