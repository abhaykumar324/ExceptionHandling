using System;

class multiplecatch
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;

            Console.WriteLine("Result = " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid integer values.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (Exception)
        {
            Console.WriteLine("Error: Some unexpected error occurred.");
        }
    }
}