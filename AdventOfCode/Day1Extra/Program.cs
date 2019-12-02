using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal total = 0;

            var numbers = File.ReadAllLines(args[0]).Select(decimal.Parse);

            foreach (var number in numbers)
            {
                var fuel = Math.Floor(number / 3) - 2;
                total += fuel;
                while (true)
                {
                    fuel = Math.Floor(fuel / 3) - 2;
                    if (fuel > 0)
                    {
                        total += fuel;
                    }
                    else
                    {
                        break;
                    }
                       
                }
            }
            Console.WriteLine(total);
            Console.ReadKey();


        }

        static decimal Calc(decimal d)
        {
            var total = Math.Floor(d / 3) - 2;
            if (total > 0)
            {
                return total + Calc(d);
            }
            return total;
        }
    }
}
