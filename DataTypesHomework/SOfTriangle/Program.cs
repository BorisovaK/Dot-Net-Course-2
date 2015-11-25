using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the values: ");
            int a = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("The S of the triangle is:");
            Console.WriteLine((a * h / 2));
        }
    }
}
