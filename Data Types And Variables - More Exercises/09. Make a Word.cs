﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string word = "";

            for (int i = 0; i < n; i++)
            {
                string letter = Console.ReadLine();
                word += letter;
            }
            Console.WriteLine("The word is: {0}", word);
        }
    }
}
