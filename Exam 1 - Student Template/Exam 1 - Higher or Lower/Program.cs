using System;

class Program
{
    static void Main(string[] args)
    {
        int counter = 0;  // Counter to track the number of inputs
        int largest = int.MinValue; // Store the largest number found so far
        int number;  // Hold most recent user input

        // Loop to get 10 numbers from the user
        while (counter < 10)
        {
            try
            {
                Console.Write($"Enter integer #{counter + 1}: ");
                string input = Console.ReadLine();

                // Try to parse the input to an integer
                if (int.TryParse(input, out number))
                {
                    // Check if the number is greater than 0
                    if (number <= 0)
                    {
                        Console.WriteLine("Error: Please enter a number greater than zero.");
                        continue;  // Skip the current step if input is invalid
                    }

                    // Update the largest number if the current number is larger
                    if (number > largest)
                    {
                        largest = number;
                    }

                    counter++; // Increment counter only when a valid number is entered
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid number.");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: Invalid input.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred.");
            }
        }

        // After collecting all 10 numbers, display the largest
        Console.WriteLine($"The largest number entered is: {largest}");
    }
}