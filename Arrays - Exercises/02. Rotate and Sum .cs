﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotationsCount = int.Parse(Console.ReadLine());

            var sumArray = new int[arr.Length];

            for (int i = 0; i < rotationsCount; i++)
            {
                RotateArray(arr);
                for (int j = 0; j < arr.Length; j++)
                {
                    sumArray[j] += arr[j];
                }
            }
            Console.WriteLine(string.Join(" ", sumArray));
        }
        static void RotateArray(int[] arr)
        {
            var lastElement = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = lastElement;
        }
    }
}
