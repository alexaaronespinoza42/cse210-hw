using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        int choice;

        do
        {
            Console.WriteLine("1.- Write a new entry");
            Console.WriteLine("2.- Display the new journal");
            Console.WriteLine("3.- Save the journal to a file");
            Console.WriteLine("4.- Load the journal from the file");
            Console.WriteLine("5.- Exit");

            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        myJournal.WriteNewEntry();
                        break;
                    case 2:
                        myJournal.DisplayJournal();
                        break;
                    case 3:
                        myJournal.SaveJournalToFile();
                        break;
                    case 4:
                        myJournal.LoadJournalFromFile();
                        break;
                    case 5:
                        Console.WriteLine("Exiting the program Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number again.");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Invalid input Please enter a valid number.");
            }

        }while (choice != 0);
    } 
}