using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Welcome to the Mindfulness App");

        while(true)
        {
            Console.WriteLine("\nSelect an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            int choice;
            while(!int.TryParse(Console.ReadLine(), out choice)|| choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 to 4");
            }

            if (choice == 4)
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }
                Activity activity;
            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectingActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                default:
                    continue;
            }

            activity.Run();

        }
    }
}