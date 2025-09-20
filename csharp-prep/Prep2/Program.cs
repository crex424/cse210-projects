using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a variable to store letter grade.
        string letter_grade;

        // Prompt user for their grade percentage and store it.
        Console.WriteLine("What is your grade percentage? ");
        string user_input = Console.ReadLine();

        // Covert the users grade percent into a integer.
        int grade_percent = int.Parse(user_input);
        // Check what letter grade the have, and store it in the letter_grade variable.
        if (grade_percent >= 90)
        {
            letter_grade = "A";
        }
        else if (grade_percent >= 80)
        {
            letter_grade = "B";
        }
        else if (grade_percent >= 70)
        {
            letter_grade = "C";
        }
        else if (grade_percent >= 60)
        {
            letter_grade = "D";
        }
        else
        {
            letter_grade = "D";
        }
        // Display letter grade.
        Console.WriteLine($"Your letter grade is {letter_grade}.");

        // Check whether the user passed their class.
        if (grade_percent >= 70)
        {
            Console.WriteLine("Congrats, you have passed.");
        }
        else
        {
            Console.WriteLine("Better luck next time. Work hard and nothing is out of your reach.");
        }
    }
}