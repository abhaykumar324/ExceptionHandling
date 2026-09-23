using System;

class FiveStudentMarks
{
    static void Main()
    {
        int[] marks = new int[5];
        int total = 0;

        try
        {
            // Enter marks for five subjects
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter marks for subject " + (i + 1) + ": ");

                marks[i] = int.Parse(Console.ReadLine());

                // Validate marks
                if (marks[i] < 0 || marks[i] > 100)
                {
                    throw new ArgumentOutOfRangeException(
                        "Marks must be between 0 and 100."
                    );
                }

                total += marks[i];
            }

            // Display results
            double percentage = total / 5.0;

            Console.WriteLine("\nTotal Marks: " + total);
            Console.WriteLine("Percentage: " + percentage + "%");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter numeric values only.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Error: Marks must be between 0 and 100.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
