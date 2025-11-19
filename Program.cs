using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            bool continueCalculating = true;

            Console.WriteLine("=================================");
            Console.WriteLine("   Welcome to Terminal Calculator");
            Console.WriteLine("=================================");
            Console.WriteLine();

            while (continueCalculating)
            {
                try
                {
                    Console.WriteLine("Select an operation:");
                    Console.WriteLine("1. Addition (+)");
                    Console.WriteLine("2. Subtraction (-)");
                    Console.WriteLine("3. Multiplication (*)");
                    Console.WriteLine("4. Division (/)");
                    Console.WriteLine("5. Modulus (%)");
                    Console.WriteLine("6. Power (^)");
                    Console.WriteLine("7. Square Root (√)");
                    Console.WriteLine("8. Exit");
                    Console.Write("\nEnter your choice (1-8): ");

                    string choice = Console.ReadLine();

                    if (choice == "8")
                    {
                        Console.WriteLine("\nThank you for using the calculator. Goodbye!");
                        break;
                    }

                    double result = 0;
                    double num1, num2;

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter first number: ");
                            num1 = GetNumberInput();
                            Console.Write("Enter second number: ");
                            num2 = GetNumberInput();
                            result = calculator.Add(num1, num2);
                            Console.WriteLine($"\nResult: {num1} + {num2} = {result}");
                            break;

                        case "2":
                            Console.Write("Enter first number: ");
                            num1 = GetNumberInput();
                            Console.Write("Enter second number: ");
                            num2 = GetNumberInput();
                            result = calculator.Subtract(num1, num2);
                            Console.WriteLine($"\nResult: {num1} - {num2} = {result}");
                            break;

                        case "3":
                            Console.Write("Enter first number: ");
                            num1 = GetNumberInput();
                            Console.Write("Enter second number: ");
                            num2 = GetNumberInput();
                            result = calculator.Multiply(num1, num2);
                            Console.WriteLine($"\nResult: {num1} * {num2} = {result}");
                            break;

                        case "4":
                            Console.Write("Enter first number: ");
                            num1 = GetNumberInput();
                            Console.Write("Enter second number: ");
                            num2 = GetNumberInput();
                            result = calculator.Divide(num1, num2);
                            Console.WriteLine($"\nResult: {num1} / {num2} = {result}");
                            break;

                        case "5":
                            Console.Write("Enter first number: ");
                            num1 = GetNumberInput();
                            Console.Write("Enter second number: ");
                            num2 = GetNumberInput();
                            result = calculator.Modulus(num1, num2);
                            Console.WriteLine($"\nResult: {num1} % {num2} = {result}");
                            break;

                        case "6":
                            Console.Write("Enter base number: ");
                            num1 = GetNumberInput();
                            Console.Write("Enter exponent: ");
                            num2 = GetNumberInput();
                            result = calculator.Power(num1, num2);
                            Console.WriteLine($"\nResult: {num1} ^ {num2} = {result}");
                            break;

                        case "7":
                            Console.Write("Enter number: ");
                            num1 = GetNumberInput();
                            result = calculator.SquareRoot(num1);
                            Console.WriteLine($"\nResult: √{num1} = {result}");
                            break;

                        default:
                            Console.WriteLine("\nInvalid choice! Please select a number between 1 and 8.");
                            break;
                    }

                    Console.WriteLine("\n---------------------------------\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nError: {ex.Message}");
                    Console.WriteLine("\n---------------------------------\n");
                }
            }
        }

        static double GetNumberInput()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out double number))
                {
                    return number;
                }
                else
                {
                    Console.Write("Invalid input! Please enter a valid number: ");
                }
            }
        }
    }
}
