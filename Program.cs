using System;

// This class performs operations on numbers
class MathOperations
{
    // This method takes two integers as parameters
    // It performs a math operation on the first number
    // and displays the second number
    public void PerformOperation(int firstNumber, int secondNumber)
    {
        // Multiply the first number by 5
        int result = firstNumber * 5;

        // Print the result of the operation
        Console.WriteLine("Result after multiplying first number by 5: " + result);

        // Print the second number
        Console.WriteLine("Second number is: " + secondNumber);
    }
}

// Main class of the program
class Program
{
    // Entry point of the application
    static void Main(string[] args)
    {
        // Create an object of MathOperations class
        MathOperations obj = new MathOperations();

        // Call method using normal parameters
        obj.PerformOperation(10, 20);

        // Call method using named parameters
        obj.PerformOperation(firstNumber: 7, secondNumber: 15);

        // Keep console open
        Console.ReadLine();
    }
}
