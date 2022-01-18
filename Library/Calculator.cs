using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Calculator : ICalculator
    {
        public double Divide(double x, double y)
        {
            if(x.Equals(0) && y.Equals(0))
            {
               throw new NotFiniteNumberException();
            }
            else if (y.Equals(0))
            {
                throw new InvalidOperationException();
            }
            else if (x.Equals(0))
            {
                return 0;
            }

            return x / y;
        }

        public double Multiply(double x, double y)
        {
            throw new NotImplementedException();
        }

        public double Subtract(double x, double y)
        {
            throw new NotImplementedException();
        }

        public double Sum(double x, double y)
        {
            throw new NotImplementedException();
        }
    }
}
