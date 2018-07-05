using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photonumber = int.Parse(Console.ReadLine());
            int date = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double sizeb = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            var size = 0.00;

            Console.WriteLine("Name: DSC_{0:D4}.jpg", photonumber);
            Console.WriteLine("Date Taken: {0:D2}/{1:D2}/{2} {3:D2}:{4:D2}", date, month, year, hours, minutes);


            if (sizeb < 1000)
            {
                size = sizeb;
                Console.WriteLine("Size: {0}B", size);
            }
            else if (sizeb >= 1000 && sizeb < 1000000)
            {
                size = sizeb / 1000;
                Console.WriteLine("Size: {0}KB", size);
            }
            else if (sizeb >= 1000000)
            {
                size = sizeb / 1000000;
                Console.WriteLine("Size: {0}MB", size);
            }
            else if (sizeb > 1000000000)
            {
                size = sizeb / 1000000000;
                Console.WriteLine("Size: {0}GB", size);
            }
            else if (sizeb > 1000000000000)
            {
                size = sizeb / 1000000000000;
                Console.WriteLine("Size: {0}TB", size);
            }


            if (width > height)
            {
                Console.WriteLine("Resolution: {0}x{1} (landscape)", width, height);
            }
            if (width == height)
            {
                Console.WriteLine("Resolution: {0}x{1} (square)", width, height);
            }
            if (width < height)
            {
                Console.WriteLine("Resolution: {0}x{1} (portrait)", width, height);
            }
        }
    }
}
