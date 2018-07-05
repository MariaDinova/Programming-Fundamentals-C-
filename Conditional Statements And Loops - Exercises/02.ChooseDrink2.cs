using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChooseDrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double sum = 0;

            switch (proffesion)
            {
                case "Athlete":
                    sum = (double)quantity * 0.70;
                    break;

                case "Businessman":
                case "Businesswoman":
                    sum = (double)quantity * 1.00;
                    break;

                case "SoftUni Student":
                    sum = (double)quantity * 1.70;
                    break;

                default:
                    sum = (double)quantity * 1.20;
                    break;
            }
            Console.WriteLine($"The {proffesion} has to pay {sum:F2}.");
        }
    }
}
