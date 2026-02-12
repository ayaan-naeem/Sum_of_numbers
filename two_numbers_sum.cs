using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b;
            int sum;

            Console.Write("Enter the first number: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter the second number: ");
            b = int.Parse(Console.ReadLine());

            sum = a + b;

            Console.WriteLine($"The sum will be: {sum}");

        }
    }
}
