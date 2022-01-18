using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Fixture
{
    public class CalculatorFactoryFixtureV2 :IDisposable
    {
        public ICalculatorFactory Calculator { get; private set; }

        public CalculatorFactoryFixtureV2()
        {
            Calculator = new CalculatorFactoryV2(new Calculator());
        }

        public void Dispose()
        {

        }
    }
}
