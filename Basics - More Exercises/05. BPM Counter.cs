using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double bpm = double.Parse(Console.ReadLine());
            double beats = double.Parse(Console.ReadLine());

            double bars = Math.Round(beats / 4.0, 1);
            double totalseconds = (60 / bpm) * beats;
            int minutes = (int)totalseconds / 60;
            int seconds = (int)totalseconds % 60;



            Console.WriteLine("{0} bars - {1}m {2}s", bars, minutes, seconds);
        }
    }
}
