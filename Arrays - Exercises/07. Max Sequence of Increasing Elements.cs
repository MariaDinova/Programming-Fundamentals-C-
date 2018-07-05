using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var startIndex = 0;
            var sequensLenght = 1;

            var bestStartIndex = 0;
            var bestSequensLenght = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    sequensLenght++;

                    if (sequensLenght > bestSequensLenght)
                    {
                        bestStartIndex = startIndex;
                        bestSequensLenght = sequensLenght;
                    }
                }
                else
                {
                    startIndex = i;
                    sequensLenght = 1;
                }
            }

            for (int i = bestStartIndex; i < bestStartIndex + bestSequensLenght; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
