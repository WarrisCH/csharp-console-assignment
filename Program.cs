using System;

// This class contains a method that performs an operation on two integers.
class MathOperations
{
    // This void method takes two integer parameters.
    // It performs a math operation on the first integer
    // and displays the second integer on the screen.
    public void PerformOperation(int firstNumber, int secondNumber)
    {
        // Multiply the first integer by 5 and store the result.
        int result = firstNumber * 5;

        // Display the result of the math operation on the first integer.
        Console.WriteLine("Result after multiplying first number by 5: " + result);

        // Display the second integer on the screen.
        Console.WriteLine("Second number is: " + secondNumber);
    }
}

// This is the main class of the console application.
class Program
{
    // Main method is the entry point of the program.
    static void Main(string[] args)
    {
        // Create an object of the MathOperations class.
        MathOperations obj = new MathOperations();

        // Call the method by passing two numbers in order.
        obj.PerformOperation(10, 20);

        // Call the method again using named parameters.
        obj.PerformOperation(firstNumber: 7, secondNumber: 15);

        // Pause the console so the output stays visible.
        Console.ReadLine();
    }
}