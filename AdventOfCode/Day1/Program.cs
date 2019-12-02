using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = File.ReadAllLines(args[0]).Select(int.Parse);
            var total = 0d;
            foreach (var number in numbers)
            {
                var fuel = Math.Floor(number / 3d) - 2;
                total += fuel;
            }
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
