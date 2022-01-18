using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.Fixture;
using Xunit;

namespace UnitTest
{
    public class CalculatorFactoryTestV2 : CalculatorFactoryTest, IClassFixture<CalculatorFactoryFixtureV2>
    {
        public CalculatorFactoryTestV2(CalculatorFactoryFixture calculatorFactoryFixture) : base(calculatorFactoryFixture)
        {

        }
    }
}
