using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickUpOneType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick up one type - string, double or int:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "int":
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine(++n);
                    break;

                case "double":
                    double f = double.Parse(Console.ReadLine());
                    Console.WriteLine(++f);
                    break;

                case "string":
                    string s = Console.ReadLine();
                    Console.WriteLine(s + "*");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}

