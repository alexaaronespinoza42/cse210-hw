using System;
using System.Reflection.Metadata;

public class ChecklistGoal : Goal
{
    private int _presentCounter;
    private int _checkCounter;
    private int _bonusCompleted;
    private bool _checked = false;

    public ChecklistGoal(string goalTitle, string goalDescription, int points, int checkCounter, int bonusCompleted, 
    int presentCounter = 0, bool GoalChecked = false) : base(goalTitle, goalDescription, 
    points)
    {
        _title = goalTitle;
        _description = goalDescription;
        _points = points;
        _checkCounter = checkCounter;
        _bonusCompleted = bonusCompleted;
        _presentCounter = presentCounter;
        _checked = GoalChecked;
    }

    public int GetCheckCounter()
    {
        return _checkCounter;
    }

    public void SetCheckCounter(int setCheckCounter)
    {  
        _checkCounter = setCheckCounter;
    }

    public int GetBonusCompleted()
    {
        return _bonusCompleted;
    }

    public void SetGetBonusCompleted(int setBonusCompleted)
    {
        _bonusCompleted = setBonusCompleted;
    }

    public int GetPresentCounter()
    {
        return _presentCounter;
    }

    public void SetPresentCounter(int setPresentCounter)
    {
        _presentCounter = setPresentCounter;
    }

    public override string GetInfo()
    {
        
        if (_checked)
        {
            return $"[X] {_title} ({_description}) -- Currently completed {GetPresentCounter()}/{_checkCounter}";            
        }
        else
        {
            return $"[ ] {_title} ({_description}) -- Currently completed {GetPresentCounter()}/{_checkCounter}";
        }
    }

    public override int GetCompleted(int userPoints)
    {
        _presentCounter = _presentCounter + 1;
        int presentCounter = _presentCounter;
        SetPresentCounter(presentCounter);

        string goalInfo = GetInfo();

        int index = listOfGoals.IndexOf(goalInfo);
        string newGoalInfo;

        if (_presentCounter == _checkCounter)
        {
            _checked = true;
            newGoalInfo = GetInfo();

            userPoints = userPoints + _bonusCompleted;
            userPoints = userPoints + _points;
        }
        else if (_presentCounter >_checkCounter)
        {
            _presentCounter = presentCounter - 1;
        }
        else
        {
            newGoalInfo = goalInfo;
            userPoints = userPoints + _points;
        }
        return userPoints;

    }
    public override string GetRepresentation()
    {
       return $"CheckList goal: {_title},{_description},{_points},{_checkCounter},{_bonusCompleted},{_presentCounter}";
    }
}