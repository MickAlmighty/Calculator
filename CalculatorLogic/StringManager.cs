using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLogic
{
    public class StringManager
    {
        private StringBuilder firstOperand;
        private StringBuilder secondOperand;
        private StringBuilder actionOperator;
        private StringBuilder equalSign;
        private StringBuilder result;
        private bool isOperandChosen = false;
        private Operation operacja;

        public StringManager()
        {
            firstOperand = new StringBuilder("0");
            secondOperand = new StringBuilder("0");
            actionOperator = new StringBuilder();
            equalSign = new StringBuilder();
            result = new StringBuilder();
        }

        public StringBuilder FirstOperand
        {
            get
            {
                return firstOperand;
            }
            private set
            {
                firstOperand.Append(value);
            }
        }
        public StringBuilder SecondOperand
        {
            get
            {
                return secondOperand;
            }
            private set
            {
                secondOperand.Append(value);
            }
        }
        public StringBuilder ActionOperator
        {
            get
            {
                return actionOperator;
            }
            private set
            {
                actionOperator.Clear();
                actionOperator.Append(value);
                isOperandChosen = true;
            }
        }

        public void AddDigitToOperand(String digit)
        {
            StringBuilder operand = new StringBuilder();

            if (isOperandChosen == false)
            {
                operand = FirstOperand;
            }
            else
            {
                operand = SecondOperand;
            }
            InsertDigitIfPosible(operand, digit);
        }
        private void InsertDigitIfPosible(StringBuilder operand, string digit)
        {
            string operandString = operand.ToString();
            if (operandString.Equals("0") && digit != ".")
            {
                operandString = digit;
                Console.WriteLine($"Pierwsza cyfra to: {digit}");
            }
            else
            {
                if (digit == "." && operandString.Contains(".") == false)
                {
                    operandString += ".";
                    Console.WriteLine("Wstawiam kropkę");
                }
                else if(digit != ".")
                {
                    operandString += digit;
                    Console.WriteLine($"Kolejna cyfra to {digit}");
                }
            }
            
            operand.Clear();
            operand.Append(operandString);
        }
        public void ChangeSignOfOperand()
        {
            StringBuilder operand = new StringBuilder();
            
            if (isOperandChosen == false)
            {
                operand = FirstOperand;
            }
            else
            {
                operand = SecondOperand;
            }

            if (isNegativeNumber(operand))
            {
                DeleteMinusSignFromOperand(operand);
            }
            else
            {
                string savedOperand = operand.ToString();
                operand.Clear();
                operand.Append("-" + savedOperand);
            }
        }

        private bool isNegativeNumber(StringBuilder operand)
        {
            string operandString = operand.ToString();
            int indexOfMinusSign = operandString.IndexOf("-");
            if (indexOfMinusSign == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void DeleteMinusSignFromOperand(StringBuilder operand)
        {
            string operandString = operand.ToString();

            int arraySize = operandString.Length;
            char[] array = new char[arraySize];
            array = operandString.ToCharArray();
            operandString = "";
            for (int i = 1; i < arraySize; i++)
            {
                operandString += array[i];
            }
            operand.Clear();
            operand.Append(operandString);
        }
        public void Execute(Double res)
        {
            //equalSign = "=";
            //result = res.ToString();
        }
    }
}
