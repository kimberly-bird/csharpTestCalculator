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
        public int x { get; set; } = 0;
        public int y { get; set; } = 0;
        public int AddTwoIntegers(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
    }
    
}
