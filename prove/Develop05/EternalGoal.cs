using System;

public class EternalGoal : Goal
{
    public EternalGoal(string goalTitle, string goalDescription, int points) 
    : base(goalTitle, goalDescription, points)
    {
        _title = goalTitle;
        _description = goalDescription;
        _points = points;
    }

    public override string GetInfo()
    {
        return $"[] {_title} ({_description})";
    }

    public override int GetCompleted(int userPoints)
    {
        GetInfo();
        userPoints = userPoints + _points;
        return userPoints;
    }
        public override string GetRepresentation()
    {
        return $"Eternal goal: {_title},{_description},{_points}";
    }
}