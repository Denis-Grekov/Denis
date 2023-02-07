using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i <= 1000; i++)
            {
                switch (true)
                {
                    case var _ when (i % 3 == 0 && i % 5 == 0):
                        Console.Write("FizzBuzz ");
                            break;

                    case var _ when (i % 3 == 0 ):
                        Console.Write("Fizz ");
                            break;

                    case var _ when (i % 5 == 0):
                        Console.Write("Buzz ");
                            break;
                    default:
                        Console.Write(i + " ");
                        break;
                }





            }
            stopwatch.Stop();


            Console.WriteLine("Elapsed:{0} ms ", stopwatch.Elapsed.TotalMilliseconds);
            Console.ReadLine();

        }

    }
    }

