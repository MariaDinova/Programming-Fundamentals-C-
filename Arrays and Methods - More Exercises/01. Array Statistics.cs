using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();

            int minNum = int.MaxValue;
            int maxNum = 0;
            int sum = 0;
            int numCount = 0;


            string[] numbers = nums.Split(' ');

            int[] arrNums = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                arrNums[i] = int.Parse(numbers[i]);
                sum += arrNums[i];
                numCount++;
                if (arrNums[i] > maxNum)
                {
                    maxNum = arrNums[i];
                }
                if (arrNums[i] < minNum)
                {
                    minNum = arrNums[i];
                }

            }
            double average = (double)sum / numCount;

            Console.WriteLine("Min = {0}", minNum);
            Console.WriteLine("Max = {0}", maxNum);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0}", average);
        }
    }
}
