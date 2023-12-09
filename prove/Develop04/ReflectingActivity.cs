using System;

public class ReflectingActivity : Activity
{
    private string[] _prompts;
    private string[] _questions;

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0)
    {
        _prompts = new string[]
        {
             "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new string[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public override void Run()
    {
        base.Run();
        int timePerQuestion = 5;
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Think about: {prompt}");
        ShowSpinner(5);
        Console.WriteLine("Now, reflect on the following questions:");
        int totalDuration = _duration;

        foreach (var question in _questions)
        {
            if(totalDuration >= timePerQuestion)
            {
                Console.WriteLine($"{question}");
                ShowSpinner(timePerQuestion);

                totalDuration -= timePerQuestion;
            }
            else
                break;
        }
        base.DisplayEndingMessage();
    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }
}