using System;

class Program
{
    static void Main(string[] args)
    {
        //This is prep 2
        Console.WriteLine("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int percent = int.Parse(gradePercentage);

        string letterGrade = "";

        if (percent >= 90)
        {
            letterGrade = "A";
        }
        else if (percent >= 80)
        {
            letterGrade = "B";
        }
        else if (percent >= 70)
        {
            letterGrade = "C";
        }
        else if (percent >= 60)
        {
            letterGrade = "D";
        }
        else if (percent < 60)
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is: {letterGrade}");

        if (percent >= 70){
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed!");
        }

    }
}