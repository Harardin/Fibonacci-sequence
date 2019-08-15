using System;
using System.Collections.Generic;
using System.Linq;

namespace InterwiewConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fibonacci sequence realization

            Console.WriteLine("Where to stop cointing");
            int number = Convert.ToInt32(Console.ReadLine());

            int first = 1;
            Console.Write("{0} ", first);
            int second = 1;
            Console.Write("{0} ", second);
            int sum = 0;

            while (number >= sum)
            {
                sum = first + second;

                Console.Write("{0} ", sum);

                first = second;
                second = sum;
            }

            Console.WriteLine("End, Press any key");
            Console.ReadKey();
        }
    }
}
