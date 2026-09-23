using System;

class ATM
{
    static void Main()
    {
        try
        {
            Console.Write("Enter account balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > balance)
            {
                throw new Exception("Insufficient balance!");
            }

            balance = balance - amount;

            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Remaining balance: " + balance);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Transaction failed: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Thank you for using the ATM.");
        }
    }
}