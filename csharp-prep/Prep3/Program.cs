using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndmGen = new Random();
        int magicNmbr = rndmGen.Next(1,101);

        int guess = -1;

        while (guess != magicNmbr)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNmbr > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNmbr < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }
        }

    }
}   