using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface ICalculatorFactory
    {
        double Calculate(string x, string y, string opt);
    }
}
