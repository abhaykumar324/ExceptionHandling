using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.Write("Enter first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                int result = num1 / num2;
                Console.WriteLine("Result = " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
        }
    }
}
