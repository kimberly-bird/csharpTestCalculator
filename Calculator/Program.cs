using System;
using System.Collections.Generic;

namespace Calculation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }

    public class Calculator
    {
        // int properties
        public int calculator { get; set; }
        public int sum;
        // method to add two integers to get the sum
        public int AddTwoIntegers(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
    }
    
}
