using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string unit = Console.ReadLine();
            double unitValue = double.Parse(Console.ReadLine());

            switch (unit)
            {
                case "miles":
                    double kilometers = unitValue * 1.6;
                    Console.WriteLine("{0} miles = {1:f2} kilometers", unitValue, kilometers);
                    break;

                case "inches":
                    double centimeters = unitValue * 2.54;
                    Console.WriteLine("{0} inches = {1:f2} centimeters", unitValue, centimeters);
                    break;

                case "feet":
                    double centimetersF = unitValue * 30;
                    Console.WriteLine("{0} feet = {1:f2} centimeters", unitValue, centimetersF);
                    break;

                case "yards":
                    double meters = unitValue * 0.91;
                    Console.WriteLine("{0} yards = {1:f2} meters", unitValue, meters);
                    break;

                case "gallons":
                    double liters = unitValue * 3.8;
                    Console.WriteLine("{0} gallons = {1:f2} liters", unitValue, liters);
                    break;
            }
        }
    }
}
