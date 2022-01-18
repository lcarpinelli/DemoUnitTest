using Library;
using System;
using Xunit;

namespace UnitTest
{
    public class CalculatorTest
    {
        private ICalculator calculator;
        public CalculatorTest()
        {
            calculator = new Calculator();
        }

        //[Fact]
        //public void Calculator_Multiply_OK()
        //{
        //    //Arrange 
        //    ICalculator calculator = new Calculator();
        //    double y = 4;
        //    double x = 2;

        //    //Act
        //    var result = calculator.Multiply(x, y);

        //    //Assert
        //    Assert.True(result == 8);
        //}

        [Theory]
        [InlineData(4,2)]
        [InlineData(3,3)]
        [InlineData(16,8)]
        public void Calculator_Divide_OK(double x, double y)
        {
            //Arrange 

            //Act
            var result = calculator.Divide(x, y);

            //Assert
            Assert.True(result == x/y);
        }
        
        [Fact]
        public void Calculator_Divide_CheckZero()
        {
            //Arrange 
            double y = 4;
            double x = 0;

            //Assert
            Assert.Throws<InvalidOperationException>(() => calculator.Divide(y,x));
        }
        
        [Fact]
        public void Calculator_Divide_CheckFirstInputZero()
        {
            //Arrange 
            double x = 0;
            double y = 4;

            //Act
            var result = calculator.Divide(x, y);

            //Assert
            Assert.True(result == 0);
        }

        [Fact]
        public void Calculator_Divide_CheckIndefinite()
        {
            //Arrange 
            double x = 0;
            double y = 0;

            //Assert
            Assert.Throws<NotFiniteNumberException>(() => calculator.Divide(y, x));
        }

    }
}
