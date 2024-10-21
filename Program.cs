using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine();
        Console.Write("Enter the second number: ");
        string input2 = Console.ReadLine();

        PerformDivision(input1, input2);
    }

    static void PerformDivision(string num1, string num2)
    {
        try
        {
            int number1 = Convert.ToInt32(num1);
            int number2 = Convert.ToInt32(num2);
            int result = number1 / number2;

            Console.WriteLine($"Result: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid integers.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: One of the numbers is too large or too small.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}