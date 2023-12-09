using System;

public class Activity
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
    public virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"{_name} Activity:");
        Console.WriteLine($"{_description}");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
    }
    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine($"Good Job! You hace completed the {_name} activity");
        Console.WriteLine($"Total time spent {_duration} seconds\n");
        ShowCountDown(3);
    }
    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++ )
        {
            Console.Write("\b/"); System.Threading.Thread.Sleep(250);
            Console.Write("\b-"); System.Threading.Thread.Sleep(250);
            Console.Write("\b\\"); System.Threading.Thread.Sleep(250);
            Console.Write("\b|"); System.Threading.Thread.Sleep(250);
        }
        Console.Write("\b "); System.Threading.Thread.Sleep(250);
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\b{i}");
            System.Threading.Thread.Sleep(1000);
        }
        Console.Write($"\b ");

    }
    public virtual void Run()
    {
        DisplayStartingMessage();
    }
}