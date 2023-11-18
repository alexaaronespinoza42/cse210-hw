using System;


class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference , "God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
            
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to reveal more words of the scripture or type 'quit' to exit the program.");
                
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
        }

        Console.WriteLine("Take care!");
    }
}
