using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hall = "";
            double sumPerHall = 0;
            double sumPerPackage = 0;
            double discount = 0;

            switch (package)
            {
                case "Normal":
                    sumPerPackage = 500;
                    discount = 5;
                    break;
                case "Gold":
                    sumPerPackage = 750;
                    discount = 10;
                    break;
                case "Platinum":
                    sumPerPackage = 1000;
                    discount = 15;
                    break;
            }

            if (groupSize <= 50)
            {
                hall = "Small Hall";
                sumPerHall = 2500;
                double totalSum = sumPerHall + sumPerPackage;
                double sumWithDiscount = totalSum - (totalSum * discount / 100);
                double sumPerPerson = sumWithDiscount / groupSize;

                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {sumPerPerson:F2}$");
            }
            else if (groupSize > 50 && groupSize <=100)
            {
                hall = "Terrace";
                sumPerHall = 5000;
                double totalSum = sumPerHall + sumPerPackage;
                double sumWithDiscount = totalSum - (totalSum * discount / 100);
                double sumPerPerson = sumWithDiscount / groupSize;

                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {sumPerPerson:F2}$");
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";
                sumPerHall = 7500;
                double totalSum = sumPerHall + sumPerPackage;
                double sumWithDiscount = totalSum - (totalSum * discount / 100);
                double sumPerPerson = sumWithDiscount / groupSize;

                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {sumPerPerson:F2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
        
            }
            
        }
    }
}
