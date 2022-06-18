using System;
using Xunit;
using CalculatorLib;

namespace CalculatorLibUnitTests
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void TestAdd2And2()
        {
            // arrange
            double a= 2;
            double b= 2;
            double expected= 4;
            var calc= new Calculator();

            // act
            double result= calc.Add(a, b);

            // assert
            Assert.Equal(result, expected);
        }

        [Fact]
        public void TestAdd2And3()
        {
            // arrange
            double a= 2;
            double b= 3;
            double expected= 5;
            var calc= new Calculator();

            // act
            double result= calc.Add(a, b);

            // assert
            Assert.Equal(result, expected);
        }
    }
}
