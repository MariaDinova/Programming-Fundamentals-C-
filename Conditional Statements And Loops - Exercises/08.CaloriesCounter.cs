using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                var ingredients = Console.ReadLine().ToLower();
                switch (ingredients)
                {
                    case "cheese": sum += 500; break;
                    case "tomato sauce": sum += 150; break;
                    case "salami": sum += 600; break;
                    case "pepper": sum += 50; break;
                    default: sum += 0; break;
                }
            }
            Console.WriteLine("Total calories: {0}", sum);
        }
    }
}
