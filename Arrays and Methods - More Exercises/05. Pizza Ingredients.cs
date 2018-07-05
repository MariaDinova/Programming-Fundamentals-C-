using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(' ');
            int lenght = int.Parse(Console.ReadLine());
            string allIngredients = "";

            int sum = 0;


            for (int i = 0; i < ingredients.Length && sum < 10; i++)
            {
                if (ingredients[i].Length == lenght)
                {
                    Console.WriteLine("Adding {0}.", ingredients[i]);
                    sum++;
                    allIngredients += ingredients[i] + ", ";
                }
                else
                {
                    continue;
                }
            }

            var result = allIngredients.Substring(0, allIngredients.Length - 2);

            Console.WriteLine("Made pizza with total of {0} ingredients.", sum);
            Console.WriteLine("The ingredients are: {0}.", result);
        }
    }
}
