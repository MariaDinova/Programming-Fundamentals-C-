using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var trains = new List<string>();

            while (input != "Traincode!")
            {
                var pattern = @"^(<\[[^0-9A-Za-z]*\].)(.\[[a-zA-Z0-9]*\].)*$";
                Regex regex = new Regex(pattern);
                var train = regex.Match(input);

                if (train.Success)
                {
                    trains.Add(train.ToString());
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\n", trains));
        }
    }
}
