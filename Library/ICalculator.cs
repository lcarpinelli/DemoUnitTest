using System;

namespace Library
{
    public interface ICalculator
    {
        double Multiply(double x, double y); 
        double Sum(double x, double y); 
        double Subtract(double x, double y); 
        double Divide(double x, double y); 
    }
}
