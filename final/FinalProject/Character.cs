using System;

public abstract class Character
{
    protected string _name;
    protected string _characteristic;
    protected int _health;
    protected int _hunger;
    protected int _strength;
    public User _user;

    public Character(string name, string characteristic)
    {
        Random random = new Random();
        _name = name;
        _characteristic = characteristic;
        _health = 60;
        _hunger = 60;
        _strength = 60;
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

        Console.WriteLine($"\n{_name} is stronger and smarter in battle.");
    }
    public void SetHealth(int health)
    {
        _health = health;
    }
    
    public void SetHunger(int hunger)
    {
        _hunger = hunger;
    }

    public void SetStrength(int strength)
    {
        _strength = strength;
    }
    public bool IsDead()
    {
        return _hunger >= 100;
    }
    public void DeathStatus()
    {
        Console.WriteLine($"\nNotification:");
        Console.WriteLine($"\nOh no! Your {_characteristic} character {_name}, though healthy and strong, has died due to extreme hunger.\n");
    }
    public abstract string Activity();
    public virtual string CharacterDetails()
    {
        return $"{_name} ({_characteristic})\nHealth: {_health}\nHunger: {_hunger}\nHappiness: {_strength}4";
    }
    public abstract string CharacterDetailsStringRepresentation();
}