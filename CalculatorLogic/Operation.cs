using System;

namespace CalculatorLogic
{
    public class Operation
    {
        public Double X1 { get; set; }
        public Double X2 { get; set; }
        public Operation()
        {
            X1 = 0;
            X2 = 0;
        }

        public Double Addition()
        {
            return X1 + X2;
        } 
        public Double Substraction()
        {
            return X1 - X2;
        }
        public Double Division()
        {
            return X1 / X2;
        }
        public Double Multiplication()
        {
            return X1 / X2;
        }
    }
}
