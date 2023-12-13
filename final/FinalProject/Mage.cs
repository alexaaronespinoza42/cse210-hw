using System;

public class Mage : Character
{
    private List<string> _activities = new List<string>();

    public Mage (string name, string characteristic) : base (name, characteristic)
    {
        _activities.Add($"{_name} the {characteristic} used 'Stone Barrier'!");
        _activities.Add($"{_name} the {characteristic} used 'Hailstorm'!");
        _activities.Add($"{_name} the {characteristic} used 'Morning Dew'!");
        _activities.Add($"{_name} the {characteristic} used 'Will of the Phoenix'!");
    }

    public override string Activity()
    {
        Random _random = new Random();
        int index = _random.Next(_activities.Count);
        return _activities[index];
    }
    public override string CharacterDetails()
    {
        return $"{_name} (The {_characteristic} Mage)\nHealth: {_health}\nHunger: {_hunger}\nStrength: {_strength}";
    }
    public override string CharacterDetailsStringRepresentation()
    {
        return $"Mage|{_name}|{_characteristic}|{_health}|{_hunger}|{_strength}";
    }
}