using System;

namespace CalculatorProject
{
    public class Calculator : ICalculator
    {
        public double Add(double value1, double value2)
        {
            return value1 + value2;
        }

        public double Divide(double value1, double value2)
        {
            if(value2 == 0)
            {
                throw new ArgumentException("Can not divide with zero");
            }
           
            return value1 / value2;
        }

        public double Divide(int value1, int value2)
        {
            if (value2 == 0)
            {
                throw new ArgumentException("Can not divide with zero");
            }

            return value1 / value2;
        }

        public double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }

        public double Subtract(double value1, double value2)
        {
            return value1 - value2;
        }
    }
}
