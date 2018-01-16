using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorShould
    {

        [Fact]
        public void AddTwoIntegers()
        {
            // Given this input to the method
            int x = 54;
            int y = 29;
            int sum = x + y;

            // We are asserting that the output should be this
            Assert.Equal(sum, 83);
        }
    }
}