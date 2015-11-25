using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionDoubleInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values:");
            double n = double.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("The result is:");
            Console.WriteLine(n / x);
        }
    }
}
