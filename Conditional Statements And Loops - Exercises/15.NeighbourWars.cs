﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());

            int healthPesho = 100;
            int healthGosho = 100;

            int round = 1;

            do
            {
                if (round % 2 != 0)
                {
                    healthGosho = healthGosho - damagePesho;
                    if (healthGosho <= 0)
                    {
                        Console.WriteLine("Pesho won in {0}th round.", round);
                        return;
                    }
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", healthGosho);
                }
                else
                {
                    healthPesho = healthPesho - damageGosho;
                    if (healthPesho <= 0)
                    {
                        Console.WriteLine("Gosho won in {0}th round.", round);
                        return;
                    }
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", healthPesho);
                }
                if (round % 3 == 0)
                {
                    healthGosho += 10;
                    healthPesho += 10;
                }
                round++;
            } while (true);
        }
    }
}
