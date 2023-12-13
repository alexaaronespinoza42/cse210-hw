using System;

public class Assassin : Character
{
    private List<string> _activities = new List<string>();

    public Assassin (string name, string characteristic) : base (name, characteristic)
    {
        _activities.Add($"{_name} the {characteristic} used 'Deep Sting'!");
        _activities.Add($"{_name} the {characteristic} used 'Shadow Attack'!");
        _activities.Add($"{_name} the {characteristic} used 'Throatcut'!");
        _activities.Add($"{_name} the {characteristic} used 'Bloody dash power'!");
    }

    public override string Activity()
    {
        Random _random = new Random();
        int index = _random.Next(_activities.Count);
        return _activities[index];
    }
    public override string CharacterDetails()
    {
        return $"{_name} (The {_characteristic} Assassin\nHealth: {_health}\nHunger: {_hunger}\nStrength: {_strength}";
    }
    public override string CharacterDetailsStringRepresentation()
    {
        return $"Assassin|{_name}|{_characteristic}|{_health}|{_hunger}|{_strength}";
    }
}