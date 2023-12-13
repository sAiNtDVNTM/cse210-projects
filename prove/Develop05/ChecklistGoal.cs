using System;
public class CheckListGoal : Goal 
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    //Constructor 
    public CheckListGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void DisplayGoal()
    {
        Console.WriteLine(GetGoalDetails());
    }
   
   public override string GetGoalDetails()
    {
        return $"{base.GetGoalDetails()}  -- Currently completed: {_amountCompleted}/{_target}"; 
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You earned {_points}!");
        int totalPoints = _points;
        

        Console.WriteLine($"Congratulations! You earned {_points}!");

        _amountCompleted++;
        if (_amountCompleted == _target)
        {       
            _isComplete = true;
            totalPoints += _bonus;
            Console.WriteLine($"Congratulations! You completed the bonus and earned {_bonus} points.");
        }

        return totalPoints;
    }

 
}
