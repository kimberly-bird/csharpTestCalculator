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
        // method to add two integers to get the sum
        public int Add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        public int Subtract(int x, int y)
        {
            int difference = x - y;
            return difference;
        }
    }
    
}
