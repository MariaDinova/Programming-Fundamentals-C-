using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double technicalMoney = 0;
            double theoreticalMoney = 0;
            double practicalMoney = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double distanceMiles = double.Parse(Console.ReadLine());
                double cargoTones = double.Parse(Console.ReadLine());
                string name = Console.ReadLine();

                double cargoKilos = cargoTones * 1000;
                double distanceMeters = distanceMiles * 1600;

                double earnedMoney = ( cargoKilos * 1.5 ) - (0.7 * distanceMeters * 2.5);

                switch (name)
                {
                    case "Technical":
                        technicalMoney += earnedMoney;
                        break;
                    case "Theoretical":
                        theoreticalMoney += earnedMoney;
                        break;
                    case "Practical":
                        practicalMoney += earnedMoney;
                        break;
                }
            }
            if (technicalMoney > theoreticalMoney && technicalMoney > practicalMoney)
            {
                Console.WriteLine($"The Technical Trainers win with ${technicalMoney:F3}.");
            }
            if (theoreticalMoney > technicalMoney && theoreticalMoney > practicalMoney)
            {
                Console.WriteLine($"The Theoretical Trainers win with ${theoreticalMoney:F3}.");
            }
            if (practicalMoney > theoreticalMoney && practicalMoney > technicalMoney)
            {
                Console.WriteLine($"The Practical Trainers win with ${practicalMoney:F3}.");
            }
        }
    }
}
