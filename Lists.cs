using System;
using System.Collections.Generic;
using System.Linq;

public class NumberListOperations
{
    public static void Main(string[] args)
    {
        List<double> numbers = new List<double>();

        Console.WriteLine("Enter numbers for the list (enter 'done' when finished):");

        string input;
        while ((input = Console.ReadLine().ToLower()) != "done")
        {
            if (double.TryParse(input, out double number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number or 'done'.");
            }
        }

        if (numbers.Count > 0)
        {
            // 1. Compute the sum
            double sum = numbers.Sum();
            Console.WriteLine($"\nSum of the numbers: {sum}");

            // 2. Compute the average
            double average = numbers.Average();
            Console.WriteLine($"Average of the numbers: {average}");

            // 3. Find the maximum number
            double maximum = numbers.Max();
            Console.WriteLine($"Maximum number in the list: {maximum}");

            // 4. Find the smallest positive number
            List<double> positiveNumbers = numbers.Where(n => n > 0).ToList();
            if (positiveNumbers.Count > 0)
            {
                double smallestPositive = positiveNumbers.Min();
                Console.WriteLine($"Smallest positive number in the list: {smallestPositive}");
            }
            else
            {
                Console.WriteLine("There are no positive numbers in the list.");
            }

            // 5. Sort the numbers and display the sorted list
            numbers.Sort();
            Console.WriteLine("Sorted list of numbers:");
            foreach (double number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No numbers were entered in the list.");
        }
    }
}