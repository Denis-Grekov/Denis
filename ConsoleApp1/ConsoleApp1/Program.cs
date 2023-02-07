using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {

        
        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i <= 1000; i++)
            {
                string a = i.ToString();
                if (i % 3 == 0 && i % 5 == 0)
                {
                    a = "FizzBuzz";
                    Console.Write(a);
                    Console.Write(" ");

                } else if (i % 3 == 0)
                {

                
                    a = "Fizz";
                    Console.Write(a);
                    Console.Write(" ");

                } else if (i % 5 == 0){

                    a = "Buzz";
                    Console.Write(a);
                    Console.Write(" ");

                }
                else
                {
                    Console.Write(i);
                    Console.Write(" ");
                }

                
                






            }
            stopwatch.Stop();
            
            
            Console.WriteLine("Elapsed:{0} ms ", stopwatch.Elapsed.TotalMilliseconds );
            Console.ReadLine();

        }

       
    }
}

