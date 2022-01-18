using Library.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class CalculatorFactory : ICalculatorFactory
    {
        private readonly ICalculator calculator;
        public CalculatorFactory(ICalculator calculator)
        {
            this.calculator = calculator;
        } 

        public double Calculate(string x, string y, string opt)
        {
            if(!double.TryParse(x, out double conversionx))
            {
                throw new ArgumentException();
            } 
            if(!double.TryParse(y, out double conversiony))
            {
                throw new ArgumentException();
            }

            if (opt == "div")
            {
                return calculator.Divide(conversionx, conversiony);
            }
            if (opt == "sum")
            {
                return calculator.Sum(conversionx, conversiony);
            }
            if (opt == "sot")
            {
                return calculator.Subtract(conversionx, conversiony);
            }
            if (opt == "mul")
            {
                return calculator.Multiply(conversionx, conversiony);
            }

            throw new OperatorException();


        }
    }
}
