﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var times = 1;

            while (times <= 10)
            {
                Console.WriteLine($"{n} X {times} = {n * times}");
                times++;
            }
        }
    }
}
