using System;

public abstract class Goal
{
    protected string _title;
    protected string _description;
    protected int _points;

    protected static List<string> listOfGoals = new List<string>();

    public Goal(string goalTitle, string goalDescription, int points)
    {
        _title = goalTitle;
        _description = goalDescription;
        _points = points;
    
    }

    public string GetName()
    {
        return _title;
    }

    public void SetName(string goalTitle)
    {
        _title = goalTitle;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetGetDescription(string goalDescription)
    {
        _description = goalDescription;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetGetPoints(int points)
    {
        _points = points;
    }

    public virtual string GetInfo()
    {
        return $"[] {_title} ({_description})";
    }

    public virtual int GetCompleted(int userPoints)
    {
        return userPoints;
    }


    public virtual string GetRepresentation()
    {
        return $"Goal: {_title},{_description},{_points},{false}";
    }
}

