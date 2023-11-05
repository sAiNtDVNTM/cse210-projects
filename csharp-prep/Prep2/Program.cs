using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage: ");
        string gradePorcentage = Console.ReadLine();
        int answer = int.Parse(gradePorcentage);
        string letter = "";

        if (answer >= 90)
        {
            letter = "A";
        }
        else if (answer >= 80) 
        {
            letter = "B";
        }
        else if (answer >= 70)
        {
            letter = "C";
        }
        else if (answer >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");

        if (answer >= 70)
        {
            Console.WriteLine("You Passed the course");
        }
        else
        {
            Console.WriteLine("Better luck the next time");
        }

    }
}