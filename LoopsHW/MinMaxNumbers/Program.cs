﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers: ");
            int i = 0, number, smallestNumber = 0, largestNumber = 0;

            while (i != 5)
            {
                number = Int32.Parse(Console.ReadLine());
                if (i == 0)
                {
                    smallestNumber = number;
                    largestNumber = number;
                }
                else
                {
                    if (smallestNumber > number)
                    {
                        smallestNumber = number;
                    }
                    if (largestNumber < number)
                    {
                        largestNumber = number;
                    }
                }
                i++;
            }
            Console.WriteLine("The largest number is " + largestNumber);
            Console.WriteLine("The smallest number is " + smallestNumber);
            Console.ReadLine();


        }

    }
}

