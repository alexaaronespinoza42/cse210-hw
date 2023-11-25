using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to our Program!");

        while(true)
        {
            DisplayMenu();

            int choice = GetMenuChoice();

            switch (choice)
            {
                case 1:
                    RunActivity(new BreathingActivity());
                    break;
                case 2:
                    RunActivity(new ReflectingActivity());
                    break;
                case 3:
                    RunActivity(new ListingActivity());
                    break;
                case 4:
                    Console.WriteLine("Exiting the program!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again!");
                    break;
            }
        }
    }
    static void DisplayMenu()
    {
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
    }

    static int GetMenuChoice()
    {
       Console.Write("Enter your choice: ");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            Console.Write("Enter your choice: ");
        }
        return choice;
    }
    static void RunActivity(Activity activity)
    {
        activity.Run();
    }
}