using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {
    }
    public override void Run()
    {
        base.Run();

        int repetitions = 3;

        for (int i = 0; i < repetitions; i++)
        {
            int singleActivityDuration = (_duration/repetitions)/2;
            Console.WriteLine();

            Console.Write("Breathe in...  ");
            ShowCountDown(singleActivityDuration);
            
            Console.WriteLine();

            Console.Write("Breathe out...  ");
            ShowCountDown(singleActivityDuration);

            Console.WriteLine();
        }
        Console.WriteLine();
        base.DisplayEndingMessage();
    }
}
