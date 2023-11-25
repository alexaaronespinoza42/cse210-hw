using System;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "Helps you relax by walking you through breathing in and out slowly.", 60)
    {}

    public override void Run()
    {
        PerformBreathingActivity();
    }

    public void PerformBreathingActivity()
    {
        DisplayStartingMessage();
        Console.WriteLine("Focus on your breathing!");
        ShowCountDown(3);

        for (int i = 0; i < _duration; i++)
        {
            Console.WriteLine("Breath in!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Breath out!");
            System.Threading.Thread.Sleep(1000);
        }
        DisplayEndingMessage();
    }

}