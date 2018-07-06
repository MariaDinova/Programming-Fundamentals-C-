using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            long thiefsId = long.MinValue;

            for (int i = 0; i < n; i++)
            {
                long id = long.Parse(Console.ReadLine());

                switch (type)
                {
                    case "sbyte":

                        if (id <= sbyte.MaxValue && id > thiefsId)
                        {
                            thiefsId = id;
                        }
                        break;

                    case "int":

                        if (id <= int.MaxValue && id > thiefsId)
                        {
                            thiefsId = id;
                        }
                        break;

                    case "long":

                        if (id <= long.MaxValue && id > thiefsId)
                        {
                            thiefsId = id;
                        }
                        break;
                }
            }
            Console.WriteLine(thiefsId);
        }
    }
}
