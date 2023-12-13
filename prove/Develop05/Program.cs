using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest!");
        int choice;
        do
        {

            GoalManager.DisplayPlayerInfo();
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice (1-6): ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                     case 1:
                        GoalManager.CreateGoal();
                        break;
                    case 2:
                        GoalManager.ListGoals();
                        break;
                    case 3:
                        GoalManager.RecordEvent();
                        break;
                    case 4:
                        GoalManager.SaveGoals();
                        break;
                    case 5:
                        GoalManager.LoadGoals();
                        break;
                    case 6:
                        Console.WriteLine("Exiting Eternal Quest. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 8.");
                        break;
                }
                            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

        } while (choice != 6);
    }
}