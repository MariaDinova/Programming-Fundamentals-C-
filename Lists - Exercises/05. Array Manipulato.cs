using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string commands = Console.ReadLine();
            while (commands != "print")
            {
                var tokens = commands.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var operation = tokens[0];

                switch (operation)
                {
                    case "add":
                        int index = int.Parse(tokens[1]);
                        int element = int.Parse(tokens[2]);
                        nums.Insert(index, element);
                        break;
                    case "addMany":
                        index = int.Parse(tokens[1]);
                        AddingRange(nums, index, tokens);
                        break;
                    case "contains":
                        element = int.Parse(tokens[1]);
                        CheckingIfContainsElement(nums, element);
                        break;
                    case "remove":
                        index = int.Parse(tokens[1]);
                        nums.RemoveAt(index);
                        break;
                    case "shift":
                        int positions = int.Parse(tokens[1]);
                        ShiftingLeft(nums, positions);
                        break;
                    case "sumPairs":
                        CalculatingTheSumOfPairs(nums);
                        break;
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }

        private static void CalculatingTheSumOfPairs(List<int> nums)
        {
            for (int i = 0; i < nums.Count - 1; i++)
            {
                nums[i] = nums[i] + nums[i + 1];
                nums.RemoveAt(i + 1);
            }

        }

        private static void CheckingIfContainsElement(List<int> nums, int element)
        {
            if (!nums.Contains(element))
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(nums.IndexOf(element));
            }
        }

        private static void AddingRange(List<int> nums, int index, string[] tokens)
        {
            index = int.Parse(tokens[1]);
            var range = new List<int>();
            for (int i = 2; i < tokens.Length; i++)
            {
                range.Add(int.Parse(tokens[i]));
            }
            nums.InsertRange(index, range);
        }

        private static void ShiftingLeft(List<int> nums, int positions)
        {
            for (int steps = 0; steps < positions; steps++)
            {
                var firstElement = nums[0];
                for (int i = 0; i < nums.Count - 1; i++)
                {
                    nums[i] = nums[i + 1];
                }
                nums[nums.Count - 1] = firstElement;
            }
        }
    }
}
