using System;
using System.Collections.Generic;

public class Arena
{
    private List<Character> _userChoosedCharacters;
    public Arena(List<Character> userChoosedCharacters)
    {
        _userChoosedCharacters = userChoosedCharacters;
    }

    public void InitializeCharactersActivity()
    {
        Console.WriteLine("\nArena Activities:\n");

        int actNumber = 1;

        foreach (Character character in _userChoosedCharacters)
        {
            string activity = character.Activity();
            Console.WriteLine($"Act {actNumber}: {activity}");
            actNumber++; 
        }

        Console.WriteLine("\nArena ended.");
    }
}