using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> comands = Console.ReadLine().Split(' ').ToList();
            var command = comands[0];

            var phonebook = new Dictionary<string, string>();

            while (command != "END")
            {
                if (command == "A")
                {
                    var name = comands[1];
                    var phone = comands[2];

                    phonebook[name] = phone;
                }
                else if (command == "S")
                {
                    var searchName = comands[1];

                    if (phonebook.ContainsKey(searchName))
                    {
                        var phoneNumber = phonebook[searchName];
                        Console.WriteLine($"{searchName} -> {phoneNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {searchName} does not exist.");
                    }
                }

                comands = Console.ReadLine().Split(' ').ToList();
                command = comands[0];
            }
        }
    }
}
