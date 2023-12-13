using System;
public class SimpleGoal : Goal
{

    //Constructor

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
    }


}