using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double volume = 0;
            double biggestVolume = 0;
            string biggestKeg = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());

                volume = Math.PI * (r * r) * h;

                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKeg = model;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
