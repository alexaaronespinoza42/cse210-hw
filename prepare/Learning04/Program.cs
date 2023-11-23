using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Alexandre Espinoza" , "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Aaron Banchon" , "Fractions" , "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssigment a3 = new WritingAssigment("Chenoa Tome", "European History" , "The Causes of the World War II by Mary Waters");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());

        GamesAssignment a4 = new GamesAssignment("Noah Espinoza", "Computer", "Roblox", "10");
        Console.WriteLine(a4.GetSummary());
        Console.WriteLine(a4.GetGameInformation());
    }
}