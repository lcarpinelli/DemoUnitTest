using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Fixture
{
    public class CalculatorFactoryFixture : IDisposable
    {
        public ICalculatorFactory Calculator { get; private set;}

        public CalculatorFactoryFixture()
        {
            Calculator = new CalculatorFactory(new Calculator());
        }

        public void Dispose()
        {

        }
    }
}
