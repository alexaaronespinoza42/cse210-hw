using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity() : base("Listing ", "Reflect and think about the good things in your life", 120)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _count = 0;
    }

    public override void Run()
    {
        PerformListingActivity();
    }

    private void PerformListingActivity()
    {
        Console.WriteLine("Get ready to think about positive things in your life!");

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowCountDown(3);

        List<string> items = GetListFromUser();
        DisplayEndingMessage();

        Console.WriteLine($"Numbers of items listes: {items.Count}");
        Console.WriteLine($"Count value: {_count}");
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();

        Console.WriteLine("Start listing items. Type 'done' when you are finished.");

        string input;
        do
        {
            Console.Write("> ");
            input = Console.ReadLine();

            if (input.ToLower() != "done")
            {
                items.Add(input);
                _count++;
            }
        } while (input.ToLower() != "done");

        return items;
    }

}
