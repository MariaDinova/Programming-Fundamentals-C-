using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var longestIncreasingSubsequence = FindLongestInvreasingSubsequence(inputArr);

            Console.WriteLine(String.Join(" ", longestIncreasingSubsequence));
        }

        static int[] FindLongestInvreasingSubsequence(int[] arr)
        {
            var lenghts = new int[arr.Length];
            var previous = new int[arr.Length];

            var bestLenght = 0;
            var lastIndex = -1;

            for (int anchor = 0; anchor < arr.Length; anchor++)
            {
                lenghts[anchor] = 1;
                previous[anchor] = -1;

                var anchorNum = arr[anchor];
                for (int i = 0; i < anchor; i++)
                {
                    var currentNum = arr[i];

                    if (currentNum < anchorNum && lenghts[i] + 1 > lenghts[anchor])
                    {
                        lenghts[anchor] = lenghts[i] + 1;
                        previous[anchor] = i;
                    }
                }
                if (lenghts[anchor] > bestLenght)
                {
                    bestLenght = lenghts[anchor];
                    lastIndex = anchor;
                }
            }
            var longestInvreasingSubsequence = new List<int>();

            while (lastIndex != -1)
            {
                longestInvreasingSubsequence.Add(arr[lastIndex]);
                lastIndex = previous[lastIndex];
            }
            longestInvreasingSubsequence.Reverse();
            return longestInvreasingSubsequence.ToArray();
        }
    }
}
