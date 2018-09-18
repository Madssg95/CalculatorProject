using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject
{
    public interface ICalculator
    {
        double Add(double value1, double value2);
        double Subtract(double value1, double value2);
        double Multiply(double value1, double value2);
        double Divide(double value1, double value2);
        double Divide(int value1, int value2);
    }
}
