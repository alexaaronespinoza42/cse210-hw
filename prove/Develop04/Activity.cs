using System;
using System.Threading;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public virtual void Run()
    {
        DisplayStartingMessage();
        ShowMotivationalMessage();
        DisplayEndingMessage();
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} - {_description}");
        ShowCountDown(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Congratulations! You completed the {_name} activity.");
        Console.WriteLine($"Time spent {_duration}");
        Thread.Sleep(3000);
    }

    protected int GetActivityDuration()
    {
        Console.Write("Enter the duration of the Activity: ");
        return int.Parse(Console.ReadLine());
    }   

    protected int GetDuration()
    {
        return _duration;
    }   

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void ShowSpinner (int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("-");
            Thread.Sleep(1000);
        }
    }

    public void ShowCountDown (int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"{i}");
            try
            {
                Console.Clear();
            }
            catch (IOException)
            {
           
            }

            Thread.Sleep(1000);
        }
    }

    protected void ShowMotivationalMessage()
    {
        Console.WriteLine("Take a moment to breathe and reflect, so you can calm down and move on.");
    }   
}

