using System;

public abstract class Character
{
    protected string _name;
    protected string _bruiser;
    protected int _health;
    protected int _hunger;
    protected int _strength;
    public User _user;

    public Character(string name, string bruiser)
    {
        Random random = new Random();
        _name = name;
        _bruiser = bruiser;
        _health = 100;
        _hunger = 100;
        _strength = 100;
    }

    public void Feed()
    {
        _health += 5;
        _strength += 5;
        _hunger -= 10;
        if (_hunger < 0)
        {
            _hunger = 0;
        }
        if (_health > 100)
        {
            _health = 100;
        }
        if (_strength > 100)
        {
            _health = 100;
        }      
        Console.WriteLine($"\n{_name} has been fed.");
    }
    public void Play()
    {
        _health += 3;
        _hunger += 5;
        _strength += 8;
        if (_strength > 100)
        {
            _strength= 100;
        }
        if (_health > 100)
        {
            _health = 100;
        }
        if (_hunger < 0)
        {
            _hunger = 0;
        }

        Console.WriteLine($"\n{_name} is happy and playful.");
    }
    public void SetHealth(int health)
    {
        _health = health;
    }
    
    public void SetHunger(int hunger)
    {
        _hunger = hunger;
    }

    public void SetStrength(int happiness)
    {
        _strength = happiness;
    }
    public bool IsDead()
    {
        return _hunger >= 100;
    }
    public void DeathStatus()
    {
        Console.WriteLine($"\nNotification:");
        Console.WriteLine($"\nOh no! Your {_bruiser} character {_name}, though healthy and strong, has died due to extreme hunger.\n");
    }
    public abstract string Activity();
    public virtual string CharacterDetails()
    {
        return $"{_name} ({_bruiser})\nHealth: {_health}\nHunger: {_hunger}\nHappiness: {_strength}4";
    }
    public abstract string CharacterDetailsStringRepresentation();
}