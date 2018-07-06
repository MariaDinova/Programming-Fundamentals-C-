using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy100 = double.Parse(Console.ReadLine());
            double sugar100 = double.Parse(Console.ReadLine());

            double energy = volume * energy100 / 100;
            double sugar = volume * sugar100 / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}
