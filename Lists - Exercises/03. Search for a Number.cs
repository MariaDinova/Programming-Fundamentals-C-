using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var actionNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numOfElements = actionNum[0];
            int numToDelete = actionNum[1];
            int searchNum = actionNum[2];
            int result = 0;
            List<int> elements = new List<int>();

            for (int i = 0; i < numOfElements; i++)
            {
                if (i < numbers.Count)
                {
                    elements.Add(numbers[i]);
                }
            }

            for (int i = 0; i < numToDelete; i++)
            {
                if (i >= 0)
                {
                    elements.RemoveRange(0, 1);
                }
            }

            if (elements.Contains(searchNum))
            {
                result = 1;
            }

            if (result != 0)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
