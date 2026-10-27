
using System;

namespace WinFormsApp1.Logic
{
    public class Calculator
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }

            return num1 / num2;
        }

        public double SquareRoot(double number)
        {
            if (number < 0)
            {
                throw new ArithmeticException(
                    "Cannot calculate square root of a negative number.");
            }

            return Math.Sqrt(number);
        }

        public double Reciprocal(double number)
        {
            if (number == 0)
            {
                throw new DivideByZeroException();
            }

            return 1 / number;
        }

        public double ChangeSign(double number)
        {
            return -number;
        }

        public double Calculate(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return Add(num1, num2);

                case "-":
                    return Subtract(num1, num2);

                case "*":
                    return Multiply(num1, num2);

                case "/":
                    return Divide(num1, num2);

                default:
                    return num2;
            }
        }
    }

    public class MemoryCalculator : Calculator
    {
        private double memoryValue;
        private bool hasMemory;

        public bool HasMemory
        {
            get { return hasMemory; }
        }

        public void MemoryClear()
        {
            memoryValue = 0;
            hasMemory = false;
        }

        public void MemorySave(double number)
        {
            memoryValue = number;
            hasMemory = true;
        }

        public double MemoryRecall()
        {
            return memoryValue;
        }

        public void MemoryAdd(double number)
        {
            if (hasMemory)
            {
                memoryValue += number;
            }
            else
            {
                memoryValue = number;
                hasMemory = true;
            }
        }
    }
}
