using System;

namespace CalculatorLogic
{
    public class Operation
    {

        public double Addition(double x1, double x2)
        {
            return x1 + x2;
        } 
        public double Substraction(double x1, double x2)
        {
            return x1 - x2;
        }
        public double Division(double x1, double x2)
        {
            return x1 / x2;
        }
        public double Multiplication(double x1, double x2)
        {
            return x1 * x2;
        }
        public double Percentage(double x1, double x2) 
        {
            return (x1 / 100.0) * x2;
        }
    }
}
