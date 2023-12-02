using System;

public class SimpleGoal : Goal
{
    private bool _checked = false;
    private bool _completed = false;

    public SimpleGoal(string goalTitle, string goalDescription, int points, bool checkedGoal = false) : base (goalTitle, goalDescription, points)
    {
        _title = goalTitle;
        _description = goalDescription;
        _points = points;
        _checked = checkedGoal;
    }

    public override string GetInfo()
        {
            if (_checked){
                _completed = true;
                return "[X]" + _title + " (" + _description + ")";}
            else
            {
                return "[] " + _title + " (" + _description + ")";}
    
        }

    public override int GetCompleted(int userPoints)
    {
        bool completed = _completed;
        _checked = true;
        if (completed == false){
            GetInfo();

            userPoints = userPoints + _points;
            completed = true;
            return userPoints;}
        else{
            GetInfo();
            return userPoints;
        }
    }

    public override string GetRepresentation()
    {
        return $"Simple goal: {_title},{_description},{_points},{_checked}";
    }
}