using System;

public class GradeCalculator
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        if (double.TryParse(input, out double gradePercentage))
        {
            // Part 1: Separate print statements for each grade
            Console.WriteLine("\n--- Part 1 ---");
            if (gradePercentage >= 90)
            {
                Console.WriteLine("Your letter grade is A.");
            }
            else if (gradePercentage >= 80)
            {
                Console.WriteLine("Your letter grade is B.");
            }
            else if (gradePercentage >= 70)
            {
                Console.WriteLine("Your letter grade is C.");
            }
            else if (gradePercentage >= 60)
            {
                Console.WriteLine("Your letter grade is D.");
            }
            else
            {
                Console.WriteLine("Your letter grade is F.");
            }

            if (gradePercentage >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Better luck next time! Keep up the effort.");
            }

            // Part 2: Single print statement using a variable
            Console.WriteLine("\n--- Part 2 ---");
            string letterGrade = "";
            if (gradePercentage >= 90)
            {
                letterGrade = "A";
            }
            else if (gradePercentage >= 80)
            {
                letterGrade = "B";
            }
            else if (gradePercentage >= 70)
            {
                letterGrade = "C";
            }
            else if (gradePercentage >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }
            Console.WriteLine($"Your letter grade is {letterGrade}.");

            if (gradePercentage >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Better luck next time! Keep up the effort.");
            }

            // Stretch Challenge: Adding + and -
            Console.WriteLine("\n--- Stretch Challenge ---");
            string signedLetterGrade = letterGrade;
            int lastDigit = (int)gradePercentage % 10;

            if (letterGrade != "F")
            {
                if (lastDigit >= 7 && gradePercentage < 100)
                {
                    signedLetterGrade += "+";
                }
                else if (lastDigit < 3 && gradePercentage > 0)
                {
                    signedLetterGrade += "-";
                }
            }

            // Handle A+ case
            if (signedLetterGrade == "A+")
            {
                signedLetterGrade = "A";
            }

            Console.WriteLine($"Your letter grade is {signedLetterGrade}.");

            if (gradePercentage >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Better luck next time! Keep up the effort.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid percentage.");
        }
    }
}