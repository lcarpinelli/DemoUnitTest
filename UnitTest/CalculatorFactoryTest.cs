using Library;
using Library.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.Fixture;
using Xunit;

namespace UnitTest
{
    public class CalculatorFactoryTest : IClassFixture<CalculatorFactoryFixture>
    {
        private ICalculatorFactory calculator;

        public CalculatorFactoryTest(CalculatorFactoryFixture calculatorFactoryFixture)
        {
            calculator = calculatorFactoryFixture.Calculator;
        }

        [Theory]
        [InlineData("4", "2", "div", 2)]
        [InlineData("3", "3", "div", 1)]
        [InlineData("16", "8", "div", 2)]
        public void CalculatorFactory_Calculate_OK(string x, string y, string opt, double resultTest)
        {
            //Arrange 


            //Act
            var result = calculator.Calculate(x, y, opt);    

            //Assert
            Assert.True(result.Equals(resultTest));
        }

        [Theory]
        [InlineData("a", "b", "div")]
        [InlineData("d", "c", "div")]
        public void Calculate_CheckConversion_KO(string x, string y, string opt)
        {
            //Arrange 

            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => calculator.Calculate(x, y, opt));
        }

        [Theory]
        [InlineData("2", "1", "null")]
        [InlineData("5", "2", " ")]
        [InlineData("5", "2", null)]
        public void Calculate_CheckOperator_KO(string x, string y, string opt)
        {
            //Arrange 

            //Act

            //Assert
            Assert.Throws<OperatorException>(() => calculator.Calculate(x, y, opt));
        }

        [Theory]
        [InlineData("2", "1", "null")]
        [InlineData("5", "2", " ")]
        public void Calculate_CheckOperator(string x, string y, string opt)
        {
            //Arrange 

            //Act

            //Assert
            Assert.Throws<OperatorException>(() => calculator.Calculate(x, y, opt));
        }


    }
}
