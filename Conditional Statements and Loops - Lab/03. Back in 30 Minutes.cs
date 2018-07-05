using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = double.Parse(Console.ReadLine());
            var minutes = double.Parse(Console.ReadLine()) + 30;

            if (minutes > 59)
            {
                hours++;
                minutes = minutes - 60;
            }
            if (hours >= 24)
            {
                hours = hours - 24;
            }
            if (minutes < 10)
            {
                Console.WriteLine("{0}:0{1}", hours, minutes);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hours, minutes);
            }
        }
    }
}
