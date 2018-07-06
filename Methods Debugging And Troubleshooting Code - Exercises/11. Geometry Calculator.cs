using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            double area = 0;

            switch (figureType)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    area = TriangleArea(side, height);
                    break;

                case "square":
                    double sideS = double.Parse(Console.ReadLine());
                    area = SquareArea(sideS);
                    break;

                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double heightR = double.Parse(Console.ReadLine());
                    area = RectangleArea(width, heightR);
                    break;

                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = CircleArea(radius);
                    break;
            }
            Console.WriteLine($"{area:f2}");
        }

        static double TriangleArea(double side, double height)
        {
            double area = (side * height) / 2;
            return area;
        }
        static double SquareArea(double side)
        {
            double area = Math.Pow(side, 2);
            return area;
        }
        static double RectangleArea(double width, double heightR)
        {
            double area = width * heightR;
            return area;
        }
        static double CircleArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
