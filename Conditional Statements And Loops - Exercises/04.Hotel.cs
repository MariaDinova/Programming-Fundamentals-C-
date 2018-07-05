using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightdcount = int.Parse(Console.ReadLine());

            double pricestudio = 0.00;
            double pricedouble = 0.00;
            double pricesuite = 0.00;

            double totalpricestudio = 0.00;
            double totalpricedouble = 0.00;
            double totalpricesuit = 0.00;


            switch (month)
            {
                case "May":
                case "October":
                    pricestudio = 50.00;
                    pricedouble = 65.00;
                    pricesuite = 75.00;
                    break;

                case "June":
                case "September":
                    pricestudio = 60.00;
                    pricedouble = 72.00;
                    pricesuite = 82.00;
                    break;

                case "July":
                case "August":
                case "December":
                    pricestudio = 68.00;
                    pricedouble = 77.00;
                    pricesuite = 89.00;
                    break;
            }

            if ((month.Equals("May") || month.Equals("October")) && nightdcount > 7)
            {
                pricestudio = pricestudio - (50 * 0.05);
            }
            else if ((month.Equals("June") || month.Equals("September")) && nightdcount > 14)
            {
                pricedouble = pricedouble - (72 * 0.10);
            }
            else if ((month.Equals("July") || month.Equals("August") || month.Equals("December")) && nightdcount > 14)
            {
                pricesuite = pricesuite - (89 * 0.15);
            }
            if ((month.Equals("September") || month.Equals("October")) && nightdcount > 7)
            {
                totalpricestudio = pricestudio * (nightdcount - 1);
                totalpricedouble = pricedouble * nightdcount;
                totalpricesuit = pricesuite * nightdcount;
            }

            else
            {
                totalpricestudio = pricestudio * nightdcount;
                totalpricedouble = pricedouble * nightdcount;
                totalpricesuit = pricesuite * nightdcount;
            }


            Console.WriteLine("Studio: {0:F2} lv.", totalpricestudio);
            Console.WriteLine("Double: {0:F2} lv.", totalpricedouble);
            Console.WriteLine("Suite: {0:F2} lv.", totalpricesuit);
        }
    }
    
}
