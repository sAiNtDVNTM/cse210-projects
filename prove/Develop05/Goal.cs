using System;
// Base class 
public class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    //Constructor 
    protected Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;

    }

    public string GetShortName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    
    public bool IsComplete()
    {
        return _isComplete;
    }

       public virtual void DisplayGoal()
    {
        Console.WriteLine(GetGoalDetails());
    }
   
    public virtual string GetGoalDetails()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description})";
    }
    
    public virtual int RecordEvent() 
    {
        Console.WriteLine($"Congratulations! You earned {_points}!");
        
        _isComplete = true;

        return _points;
    }



}