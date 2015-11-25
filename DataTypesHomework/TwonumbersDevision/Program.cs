using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwonumbersDevision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("The result is:");
            Console.WriteLine(a % b);
        }
    }
}
