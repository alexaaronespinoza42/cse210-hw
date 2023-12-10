using System;
using Microsoft.VisualBasic;

public class User
{
    private string _name;
    public User(string name)
    {
        _name = name;
    }

    public void ChooseBruiser(Character character, string name, string bruiser)
    {
        Console.WriteLine($"\n{_name} you created a new {bruiser} {character}!");
        Console.WriteLine($"{name} the {bruiser} {character} is a character.");
    } 
    public void FeedCharacter(Character character)
    {
        character.Feed();
    }
    public void TrainWithCharacter(Character character)
    {
        character.Play();
    }
}