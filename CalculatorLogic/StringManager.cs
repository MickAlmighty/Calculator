using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLogic
{
    public class StringManager
    {
        private StringBuilder firstOperand;
        private StringBuilder secondOperand;
        private string actionOperator;
        private StringBuilder equalSign;
        private bool isOperandChosen = false;
        private Operation operacja;

        public string Result { get; set; }
        public StringManager()
        {
            firstOperand = new StringBuilder("0");
            secondOperand = new StringBuilder("0");
            equalSign = new StringBuilder();
            operacja = new Operation();
        }

        public StringBuilder FirstOperand
        {
            get
            {
                return firstOperand;
            }
            set
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
            set
            {
                secondOperand.Append(value);
            }
        }
        public String ActionOperator
        {
            get
            {
                return actionOperator;
            }
            set
            {
                //actionOperator.Clear();
                actionOperator = value;
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
            }
            else
            {
                if (digit == "." && operandString.Contains(".") == false)
                {
                    operandString += ".";
                }
                else if (digit != ".")
                {
                    operandString += digit;
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
        public void Execute()
        {   
            double firstOperand = double.Parse(PrepareToParse(FirstOperand.ToString()));
            double secondOperand = double.Parse(PrepareToParse(SecondOperand.ToString()));
            double result = 0;
            switch (actionOperator)
            {
                case "+":
                    {
                        result = operacja.Addition(firstOperand, secondOperand);
                        break;
                    }
                case "-":
                    {
                        result = operacja.Substraction(firstOperand, secondOperand);
                        break;
                    }
                case "/":
                    {
                        result = operacja.Division(firstOperand, secondOperand);
                        break;
                    }
                case "*":
                    {
                        result = operacja.Multiplication(firstOperand, secondOperand);
                        break;
                    }
                case "%":
                    {
                        result = operacja.Percentage(firstOperand, secondOperand);
                        break;
                    }
                default:
                    {
                        Result = "0";
                        break;
                    }
            }
            Result = result.ToString().Replace(',', '.');
            ClearOperands();
        }
        public string PrepareToParse(string toParse)
        {

            if (toParse.Contains("."))
            {
                toParse.Replace('.', ',');
                return toParse;
            }
            else return toParse;
        }
        private void ClearOperands()
        {
            FirstOperand = new StringBuilder("0");
            SecondOperand = new StringBuilder("0");
        }

        public string DisplayOperand()
        {
            if (isOperandChosen == false)
            {
                return FirstOperand.ToString();
            }
            else
            {
                return SecondOperand.ToString();
            }
        }
    }   
}
