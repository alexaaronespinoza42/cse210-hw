using System;
using Microsoft.VisualBasic;

public class User
{
    private string _name;
    public User(string name)
    {
        _name = name;
    }

    public void CreateCharacter(Character character, string name, string characteristic)
    {
        Console.WriteLine($"\n{_name} you created a new {characteristic} {character}!");
        Console.WriteLine($"{name} the {characteristic} {character} is a character.");
    } 
    public void FeedCharacter(Character character)
    {
        character.Feed();
    }
    public void PlayWithCharacter(Character character)
    {
        character.Play();
    }
}