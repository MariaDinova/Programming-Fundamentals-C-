using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            long lokoPower = long.Parse(Console.ReadLine());

            var vagons = new List<long>();

            var input = Console.ReadLine();
           
            long sum = 0;
            long averageSum = 0;
            long average = 0;
            long closest = 0;
            int index = 0;

            while (input != "All ofboard!")
            {
                long vagon = long.Parse(input);
                sum = sum + vagon;
                vagons.Add(vagon);

                if (sum > lokoPower)
                {
                    for (int i = 0; i < vagons.Count; i++)
                    {
                        averageSum = averageSum + vagons[i];
                        average = averageSum / vagons.Count;
                    }
                    closest = vagons.OrderBy(item => Math.Abs(vagons.Average() - item)).First();
                    index = (int)vagons.IndexOf(closest);
                    vagons.RemoveAt(index);
                }
                input = Console.ReadLine();
            }
            vagons.Reverse();
            vagons.Add(lokoPower);
            Console.WriteLine(String.Join(" ", vagons));
        }
    }
}
