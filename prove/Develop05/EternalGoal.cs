using System;

public class EternalGoal : Goal
{

    //Constructor 
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }

    public override int RecordEvent() 
    {
        Console.WriteLine($"Congratulations! You earned {_points}!");
        
        _isComplete = false;

        return _points;
    }

}