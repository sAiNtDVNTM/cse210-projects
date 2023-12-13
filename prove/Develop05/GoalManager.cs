public abstract class GoalManager
{
    private static List<Goal> _goals = new List<Goal>();
    private static int _playerScore = 0;

    // Display the player's current score
    public static void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player's Score: {_playerScore}");
    }

   // Create a new goal and add it to the list
    public static void CreateGoal()
    {
        Console.Write("\nEnter Goal Type (Simple, Eternal, or Checklist): ");
        string goalType = Console.ReadLine().ToLower();

        Console.Write("Enter Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Goal Description: ");
        string description = Console.ReadLine();

        Console.Write("Enter Points for Completing the Goal: ");
        int points;
        while (!int.TryParse(Console.ReadLine(), out points))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }

        Goal newGoal;
        switch (goalType)
        {
            case "simple":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "eternal":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "checklist":
                Console.Write("Enter Target Amount for Checklist: ");
                int target;
                while (!int.TryParse(Console.ReadLine(), out target))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }
                Console.Write("Enter Bonus Points for Completing Checklist: ");
                int bonus;
                while (!int.TryParse(Console.ReadLine(), out bonus))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }
                newGoal = new CheckListGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type. Please choose Simple, Eternal, or Checklist.");
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    // List the names of each goal
    public static void ListGoals()
    {
        Console.WriteLine("\nGoal Names:");
        foreach (var goal in _goals)
        {
            goal.DisplayGoal();
        }
    }
 
    // Record an event for a specific goal
    public static void RecordEvent()
    {
        Console.WriteLine("\nSelect a goal to record an event:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }

        int goalIndex;
        while (!int.TryParse(Console.ReadLine(), out goalIndex) || goalIndex < 1 || goalIndex > _goals.Count)
        {
            Console.Write("Invalid input. Please enter a valid goal number: ");
        }

        _playerScore += _goals[goalIndex - 1].RecordEvent();

        /*
        _goals[goalIndex - 1].RecordEvent();
        _playerScore += _goals[goalIndex - 1]._points;
        */
    }

    // Save the list of goals to a file
    public static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.GetShortName()},{goal.GetDescription()},{goal.GetPoints()}");
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    // Load goals from a file
    public static void LoadGoals()
    {
        _goals.Clear();
        try
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string[] parts = reader.ReadLine().Split(',');
                    if (parts.Length >= 4)
                    {
                        Goal newGoal;
                        switch (parts[0])
                        {
                            case nameof(SimpleGoal):
                                newGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                                break;
                            case nameof(EternalGoal):
                                newGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                                break;
                            case nameof(CheckListGoal):
                                if (parts.Length >= 6 && int.TryParse(parts[4], out int target) && int.TryParse(parts[5], out int bonus))
                                {
                                    newGoal = new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), target, bonus);
                                }
                                else
                                {
                                    continue; // Skip incomplete checklist goals
                                }
                                break;
                            default:
                                continue; // Skip unknown goal types
                        }
                        _goals.Add(newGoal);
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. No goals loaded.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }

}  






                    