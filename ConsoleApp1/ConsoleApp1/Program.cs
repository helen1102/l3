using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);


            Console.ReadKey();

        }
    }
}
