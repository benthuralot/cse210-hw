using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        Console.Write("Enter your grade percentage: ");
        string percent = Console.ReadLine();
        int grade = int.Parse(percent);

        string letter = ""; // Variable to store the letter grade

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Check if the student passed the course
        if (grade >= 70)
        {
            Console.WriteLine($"Congratulations! You passed with a {letter}.");
        }
        else
        {
            Console.WriteLine($"Sorry, you did not pass. Better luck next time!");
        }

        // Print the letter grade separately
        Console.WriteLine($"Letter Grade: {letter}");
    }
}