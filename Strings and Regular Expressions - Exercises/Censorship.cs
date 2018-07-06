using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            string censor = Console.ReadLine();
            var sentense = Console.ReadLine();

            sentense = sentense.Replace(censor, new string('*', censor.Length));


            Console.WriteLine(sentense);
        }
    }
}
