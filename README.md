# Terminal Calculator

A simple command-line calculator application written in C# with basic arithmetic operations.

## Features

The calculator supports the following operations:
- **Addition (+)**: Add two numbers
- **Subtraction (-)**: Subtract one number from another
- **Multiplication (*)**: Multiply two numbers
- **Division (/)**: Divide one number by another (with zero-check)
- **Modulus (%)**: Get the remainder of division
- **Power (^)**: Raise a number to a power
- **Square Root (√)**: Calculate the square root of a number (with negative-check)

## Requirements

- .NET 9.0 SDK or later

## How to Run

1. Make sure you have .NET SDK installed. Check with:
   ```bash
   dotnet --version
   ```

2. Navigate to the project directory:
   ```bash
   cd /Users/robbie/Tab/Projects/Calc
   ```

3. Run the application:
   ```bash
   dotnet run
   ```

## How to Use

1. When the application starts, you'll see a menu with operation options
2. Enter the number corresponding to the operation you want to perform (1-8)
3. Enter the required number(s) when prompted
4. The result will be displayed
5. The menu will appear again for the next calculation
6. Select option 8 to exit the application

## Example Usage

```
=================================
   Welcome to Terminal Calculator
=================================

Select an operation:
1. Addition (+)
2. Subtraction (-)
3. Multiplication (*)
4. Division (/)
5. Modulus (%)
6. Power (^)
7. Square Root (√)
8. Exit

Enter your choice (1-8): 1
Enter first number: 15
Enter second number: 25

Result: 15 + 25 = 40

---------------------------------
```

## Error Handling

The calculator includes error handling for:
- Division by zero
- Square root of negative numbers
- Invalid input (non-numeric values)
- Invalid menu choices

## Project Structure

- `Program.cs` - Main program with user interface and menu
- `Calculator.cs` - Calculator class with all arithmetic operations
- `Calc.csproj` - C# project configuration file
