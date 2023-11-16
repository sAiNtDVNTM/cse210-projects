using System;

public abstract class PromptGenerator
{
    public static List<string> Prompts = new List<string>()// This is the class to generate the random prompt. 
        {
                "What was the best part of your day?",
                "What was the dream of the day?",
                "What was your favorite thought or insight of the day?",
                "Write about an experience where you felt the spirit with you today:",
                "The quote for today?",
                "Who was the most interesting person you interacted with today?",
                "Write down something you are stress about and how you are fighting to overcome?",
                "Write about the place you call home",
                "Write about something that happened for which you are grateful today:",
                "How do you see the world today?",
                "If you had one thing you could do over today, what would it be?",
                "Your favorite song of the day?",
                "What was the strongest emotion you felt today?",
                "What do you love about yourself today?",
                "Write about an act of service you either witnessed or performed today:>",
                "Write about someone you love today:",
                "Write about something you learned today:",
                "Something you are proud of today?",
                "Write about a tender mercy you noticed today:",
                "Write down one regret of today:",
                "Write about a positive interaction you had with someone else today:",
                "A few small things that make you happy today?",
                "Write about something you noticed that reminded you of Jesus Christ today:",
                "Something you want to remember:",
                "Write about something you learned about someone in your life today:",
                "What did I achieve today?",
                "Write about an experience you had that allowed you to teach someone else today:",
                "What could I have done better today?"
        };

    public static string GenerateRandomPrompt()
    {
        return Prompts[new Random().Next(Prompts.Count)];
    }
}