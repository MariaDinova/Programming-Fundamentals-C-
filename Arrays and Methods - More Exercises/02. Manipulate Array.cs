using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArr = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');


                if (command.Length == 1)
                {
                    switch (command[0])
                    {
                        case "Reverse":
                            Array.Reverse(stringArr);
                            break;

                        case "Distinct":
                            string[] temp = stringArr.Distinct().ToArray();
                            stringArr = temp;
                            break;
                    }
                }
                else
                {
                    int position = int.Parse(command[1]);
                    string replaceWord = command[2];
                    stringArr[position] = replaceWord;
                }


            }
            Console.WriteLine(string.Join(", ", stringArr));
        }
    }
}
