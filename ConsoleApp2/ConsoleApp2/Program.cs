using System;

// Define the class that will contain our method
class MathOperationExample
{
    // Method that performs a mathematical operation and displays a value
    void PerformOperation(int num1, int num2)
    {
        // Perform addition on num1 and store the result
        int result = num1 * 2;

        // Display the result of the operation
        Console.WriteLine($"The result of the operation on {num1} is: {result}");

        // Display the second number without performing any operation on it
        Console.WriteLine($"The second number is: {num2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of MathOperationExample
        MathOperationExample example = new MathOperationExample();

        // Call PerformOperation method with positional arguments
        example.PerformOperation(10, 5);

        // Call PerformOperation method with named arguments
        example.PerformOperation(num1: 7, num2: 3);

        // Wait for user input before closing the console
        Console.ReadLine();
    }
}