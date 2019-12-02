using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Extra
{
    class Program
    {
        private const int SUM_INT = 1;
        private const int MULT_INT = 2;
        private const int HALT_INT = 99;
        private const int EXPECTED_NUMBER = 19690720;

        static void Main(string[] args)
        {
            var original = File.ReadAllText(args[0]).Split(',').Select(int.Parse).ToList();

            for (var y = 1; y < 100; y++)
            {
                for (var z = 1; z < 100; z++)
                {
                    var numbers = original.ToList();

                    numbers[1] = y;
                    numbers[2] = z;

                    var i = 0;
                    while(true)
                    {
                        var n = numbers[i];
                        if (n == HALT_INT)
                        {
                            break;
                        }

                        switch (n)
                        {
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
                        i++;
                    }

                    
                    var firstPos = numbers[0];

                    Console.Write(firstPos + "; ");
                    if (firstPos != EXPECTED_NUMBER) continue;

                    Console.WriteLine(string.Join(",", numbers));
                    Console.WriteLine(100 * y + z);
                    Console.ReadKey();
                    return;
                }
            }
            Console.ReadKey();

        }
    }
}
