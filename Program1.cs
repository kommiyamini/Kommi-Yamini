using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorApp
{
    class Calculator
    {
        private double a;
        private double b;
        private string operation;

    
    public Calculator(double a, double b, string operation)
    {
        this.a = a;
        this.b = b;
        this.operation = operation.ToLower();
    }
        public double Calculate()
        {
            switch (operation)
            {
                case "add":
                case "addition":
                    return a + b;
                case "subtract":
                case "subtraction":
                    return a - b;
                case "multiply":
                case "multiplication":
                    return a * b;
                case "divide":
                case "division":
                    if (b == 0)
                        throw new DivideByZeroException("Cannot divide by zero.");
                    return a / b;
                default:
                    throw new InvalidOperationException("Invalid operation type.");

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number(a):");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number(b):");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter operation(add, subtract, multiply, divide ):");
                string operation = Console.ReadLine();
                Calculator calc = new Calculator(a, b, operation);
                double result = calc.Calculate();
                Console.WriteLine($"Result: {result}");

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
