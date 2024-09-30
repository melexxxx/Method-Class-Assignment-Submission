using System;

// This class will contain our mathematical operation method
public class MathOperation
{
    // Method that performs operations on two integers
    public void PerformOperation(int num1, int num2)
    {
        // Multiply the first number by 2 as an example operation
        int result = num1 * 2;

        // Display the result of the operation
        Console.WriteLine($"The result of the operation on {num1} is: {result}");

        // Display the second number without performing any operation on it
        Console.WriteLine($"The second number is: {num2}");
    }
}