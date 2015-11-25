using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEqualToAnother
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string here: ");
            string n = Console.ReadLine();
            string b = "Hello World";

            Console.WriteLine("Is it {0} == {1}?", n, b);
            Console.WriteLine(n == b);
        }
    }
}
