using System;
public class ListingActivity : Activity
{
    private int _count;
    private string[] _prompts;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
        _prompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "Are you thinking heavenly?"
        };
    }
    public override void Run()
    {
        base.Run();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Think about: {prompt}");
        ShowCountDown(10);
        Console.WriteLine("Now, start listing as many items as you can: ");
        _count = GetListFromUser();
        Console.WriteLine($"You listed {_count} items.");
        base.DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }
    private int GetListFromUser()
    {
        int count = 0;
        int timeRemaining = _duration;
        while(timeRemaining > 0)
        {
            DateTime start = DateTime.Now;
            Console.Write($"Item {count + 1}: ");
            Console.ReadLine();
            count++;
            DateTime end = DateTime.Now;

            int secondsSpent = (end - start).Seconds;
            timeRemaining -= secondsSpent;
        }
        return count;
    }
}