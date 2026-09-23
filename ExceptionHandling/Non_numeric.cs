using System;

class Program
{
    static void Main2()
    {
        try
        {
            Console.Write("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered: " + num);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid numeric value.");
        }
    }
}