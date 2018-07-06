using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string text = Console.ReadLine();

            int skipElement = input[0];
            int takeElement = input[1];

            string pattern = $@"\|<(\w*)";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);
            var list = new List<string>();

            foreach (Match item in matches)
            {
                var arr = item.Groups[1].Value.Skip(skipElement).Take(takeElement).ToArray();
                var result = "";

                for (int i = 0; i < arr.Length; i++)
                {
                    result += arr[i];
                }

                list.Add(result);
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
