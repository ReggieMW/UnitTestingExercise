using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(10, 7, 11, 28)]
        [InlineData(10, -7, 15, 18)]
        [InlineData(0, 3, 5, 8)]
        
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            var calculator = new Calculator();
            
            var actual = calculator.Add(num1, num2, num3);
            
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(25, 15, 10)]
        [InlineData(25, -15, 40)]
        [InlineData(1, 8, -7)]
        [InlineData(5, 8, -3)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
           var calculator = new Calculator();

            var actual = calculator.Subtract(minuend, subtrahend);
            
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(16, 0, 0)]
        [InlineData(7, -7, -49)]
        [InlineData(-7, -7, 49)]
        [InlineData(6, 2, 12)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            var calculator = new Calculator();

            var actual = calculator.Multiply(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, "2")]
        [InlineData(100, 10, "10")]
        [InlineData(50, 100, "0.5")]
        [InlineData(-8, 4, "-2")]
        [InlineData(5, 0, "Error: cannot divide by zero.")]
        
        public void DivideTest(double num1, double num2, string expected)
        {
            var calculator = new Calculator();

            var actual = calculator.Divide(num1, num2);

            Assert.Equal(expected, actual);
        }

    }
}
