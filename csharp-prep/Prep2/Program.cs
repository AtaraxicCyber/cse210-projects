using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade?");
        string percentGradeString = Console.ReadLine();
        int percentGrade = int.Parse(percentGradeString);
        string grade;

        if (percentGrade >= 90)
        {
            grade = "A";
        }
        else if (percentGrade >= 80)
        {
            grade = "B";
        }
        else if (percentGrade >= 70)
        {
            grade = "C";
        }
        else if (percentGrade >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"You earned a {grade}");
        if (percentGrade >= 70)
        {
            Console.WriteLine("You passed. Congratulations!");
        }
        else
        {
            Console.WriteLine("You failed. Better luck next time!");
        }

    }
}