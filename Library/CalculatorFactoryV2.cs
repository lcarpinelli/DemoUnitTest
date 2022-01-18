using Library.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class CalculatorFactoryV2 : ICalculatorFactory
    {
        private readonly ICalculator calculator;
        public CalculatorFactoryV2(ICalculator calculator)
        {
            this.calculator = calculator;
        }

        public double Calculate(string x, string y, string opt)
        {
            if (!double.TryParse(x, out double conversionx))
            {
                throw new ArgumentException();
            }
            if (!double.TryParse(y, out double conversiony))
            {
                throw new ArgumentException();
            }

            switch (opt)
            {
                case "div":
                    return calculator.Divide(conversionx, conversiony);
                case "sum":
                    return calculator.Sum(conversionx, conversiony);
                case "sot":
                    return calculator.Sum(conversionx, conversiony);
                case "mul":
                    return calculator.Sum(conversionx, conversiony);
            }

            throw new OperatorException();


        }
    }
}
