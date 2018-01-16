using System;
using Xunit;

namespace Calculation.Tests
{
    public class CalculatorShould
    {
        private Calculator _calculator;

        public CalculatorShould()
        {
            // new instance of Calculator
            _calculator = new Calculator();
        }

        [Fact]
        public void AddTwoIntegers()
        {
            // Given this input to the method
            int sum = _calculator.AddTwoIntegers(54, 29);

            // We are asserting that the output should be this
            Assert.Equal(83, sum);
        }
    }
}