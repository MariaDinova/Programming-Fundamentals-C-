using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            string word = string.Empty;
            
            for (int letters = 1; letters <= lines; letters++)
            {
                int finalLetter = char.Parse(Console.ReadLine());

                finalLetter = ((char)(finalLetter + key));

                word += (char)finalLetter;
            }
            Console.WriteLine(word);
        }
    }
}
