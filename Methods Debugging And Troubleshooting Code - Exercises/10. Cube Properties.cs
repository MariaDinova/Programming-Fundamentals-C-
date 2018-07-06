using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double result = 0;

            switch (parameter)
            {
                case "face":
                    result = Face(size);
                    break;
                case "space":
                    result = Space(size);
                    break;
                case "volume":
                    result = Volume(size);
                    break;
                case "area":
                    result = Area(size);
                    break;
            }
            Console.WriteLine($"{result:f2}");

        }
        static double Face(double size)
        {
            double result = Math.Sqrt(2 * Math.Pow(size, 2));
            return result;
        }

        static double Space(double size)
        {
            double result = Math.Sqrt(3 * Math.Pow(size, 2));
            return result;
        }

        static double Volume(double size)
        {
            double result = Math.Pow(size, 3);
            return result;
        }

        static double Area(double size)
        {
            double result = 6 * Math.Pow(size, 2);
            return result;
        }
    }
}
