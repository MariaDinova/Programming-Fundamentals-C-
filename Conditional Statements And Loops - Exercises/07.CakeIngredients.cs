using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = Console.ReadLine();
            var sum = 0;

            while (ingredients != "Bake!")
            {
                Console.WriteLine("Adding ingredient {0}.", ingredients);
                sum++;
                ingredients = Console.ReadLine();
            }

            Console.WriteLine("Preparing cake with {0} ingredients.", sum);
        }
    }
}
