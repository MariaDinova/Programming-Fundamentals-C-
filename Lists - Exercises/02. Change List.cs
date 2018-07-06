using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var oddResult = new List<int>();
            var evenResult = new List<int>();



            while (true)
            {
                List<string> comands = Console.ReadLine().Split(' ').ToList();
                string command = comands[0];
                switch (command)
                {
                    case "Delete":
                        int deleteElement = (int.Parse(comands[1]));
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (deleteElement == numbers[i])
                            {
                                numbers.Remove(numbers[i]);
                                i--;
                            }
                        }
                        break;

                    case "Insert":
                        int element = (int.Parse(comands[1]));
                        int index = (int.Parse(comands[2]));
                        numbers.Insert(index, element);
                        break;

                    case "Odd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                oddResult.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(String.Join(" ", oddResult));
                        break;

                    case "Even":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                evenResult.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(String.Join(" ", evenResult));
                        break;
                }

                if (command == "Odd" || command == "Even")
                {
                    break;
                }


            }

        }
    }
}
