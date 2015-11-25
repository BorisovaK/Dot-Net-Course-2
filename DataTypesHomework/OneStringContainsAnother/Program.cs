using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneStringContainsAnother
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string that you want to check:");
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            bool z = y.Contains(x);
            Console.WriteLine(z);
        }
    }
}
