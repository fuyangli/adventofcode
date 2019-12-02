using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        private const int SUM_INT = 1;
        private const int MULT_INT = 2;
        private const int HALT_INT = 99;

        static void Main(string[] args)
        {
            var numbers = File.ReadAllText(args[0]).Split(',').Select(int.Parse).ToList();
            //var numbers = new List<int>() { 1,1,1,4,99,5,6,0,99 };

            numbers[1] = 12;
            numbers[2] = 2;

            var halt = false;
            for (int i = 0; !halt && i < numbers.Count; i++)
            {
                var n = numbers[i];
                switch (n)
                {
                    case HALT_INT:
                    {
                        halt = true;
                        break;
                    }
                    case SUM_INT:
                    {
                        var a = numbers[numbers[++i]];
                        var b = numbers[numbers[++i]];
                        var pos = numbers[++i];
                        var result = a + b;
                        numbers[pos] = result;
                        break;
                    }
                    case MULT_INT:
                    {
                        var a = numbers[numbers[++i]];
                        var b = numbers[numbers[++i]];
                        var pos = numbers[++i];
                        var result = a * b;
                        numbers[pos] = result;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(",", numbers));
            Console.ReadKey();
        }
    }
}
