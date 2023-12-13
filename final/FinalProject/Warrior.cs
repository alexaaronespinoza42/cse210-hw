using System;

public class Warrior : Character
{
    private List<string> _activities = new List<string>();

    public Warrior (string name, string characteristic) : base (name, characteristic)
    {
        _activities.Add($"{_name} the {characteristic} used 'Quick Strike'!");
        _activities.Add($"{_name} the {characteristic} used 'Raging Blow'!");
        _activities.Add($"{_name} the {characteristic} used 'Berserk Stance'!");
        _activities.Add($"{_name} the {characteristic} used 'Bloodrage'!");
    }

    public override string Activity()
    {
        Random _random = new Random();
        int index = _random.Next(_activities.Count);
        return _activities[index];
    }
    public override string CharacterDetails()
    {
        return $"{_name} (The {_characteristic} Warrior)\nHealth: {_health}\nHunger: {_hunger}\nStrength: {_strength}";
    }
    public override string CharacterDetailsStringRepresentation()
    {
        return $"Warrior|{_name}|{_characteristic}|{_health}|{_hunger}|{_strength}";
    }
}