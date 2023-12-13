using System;

public class Archer : Character
{
    private List<string> _activities = new List<string>();

    public Archer (string name, string characteristic) : base (name, characteristic)
    {
        _activities.Add($"{_name} the {characteristic} used 'Quick Shot'!");
        _activities.Add($"{_name} the {characteristic} used 'Blazing Arrow'!");
        _activities.Add($"{_name} the {characteristic} used 'Frost Arrow'!");
        _activities.Add($"{_name} the {characteristic} used 'Vicious Arrow'!");
    }

    public override string Activity()
    {
        Random _random = new Random();
        int index = _random.Next(_activities.Count);
        return _activities[index];
    }
    public override string CharacterDetails()
    {
        return $"{_name} (The {_characteristic} Archer)\nHealth: {_health}\nHunger: {_hunger}\nStrength: {_strength}";
    }
    public override string CharacterDetailsStringRepresentation()
    {
        return $"Archer|{_name}|{_characteristic}|{_health}|{_hunger}|{_strength}";
    }
}