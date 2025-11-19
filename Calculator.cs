using System;

namespace Calc
{
    public class Calculator
    {
        // Addition
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Subtraction
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Multiplication
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Division
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero!");
            }
            return a / b;
        }

        // Modulus
        public double Modulus(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot perform modulus with zero!");
            }
            return a % b;
        }

        // Power
        public double Power(double baseNum, double exponent)
        {
            return Math.Pow(baseNum, exponent);
        }

        // Square Root
        public double SquareRoot(double number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Cannot calculate square root of a negative number!");
            }
            return Math.Sqrt(number);
        }
    }
}
