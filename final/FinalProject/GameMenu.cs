using System;
using System.Collections.Generic;
using System.IO;

public class GameMenu
{
    private List<Character> _characters;
    private string _userName;
    public GameMenu()
    {
        _characters = new List<Character>();
        _userName = "Default";
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the MMORPG character game!");
        Console.WriteLine("\nPress 1 for a New Game");
        Console.WriteLine("Press 2 to Load Game\n");
        string _choice = Console.ReadLine();

        Console.Clear();
        if (_choice == "1")
        {
            
            Console.Write("Hello there! To begin your adventure. What name should we call you? ");
            _userName = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Hello {_userName}! Get ready to embark on an exciting but dangerous adventure! Create, feed, and train with your character. Let the adventure begin!");
        }
        else if (_choice == "2")
        {
            Console.Write("\nTo load past game, please enter the filename: ");
            string _fileName = Console.ReadLine();
            LoadGame(_fileName);
        }

        while (true)
        {               
            Console.WriteLine($"\nMMORPG character game");
            DisplayCharacterOwnerInfo();
            
            CheckHunger();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create character");
            Console.WriteLine("2. Feed character");
            Console.WriteLine("3. Play with character");
            Console.WriteLine("4. Check Character Status");
            Console.WriteLine("5. Go Arena");
            Console.WriteLine("6. Save Game"); 
            Console.WriteLine("7. Quit");

            Console.Write("\nSelect a choice from the menu: ");
            string _userChoice = Console.ReadLine();

            while (true)
            {
                if (_userChoice == "1")
                {
                    CreateCharacter();
                    break;
                }
                else if (_userChoice == "2")
                {
                    
                    FeedCharacter();
                    break;
                }
                else if (_userChoice == "3")
                {
                    PlayWithCharacter();
                    break;
                }
                else if (_userChoice == "4")
                {
                    ViewCharacterStatus();
                    break;
                }
                else if (_userChoice == "5")
                {
                    Arena arena = new Arena(_characters);
                    arena.InitializeCharactersActivity();
                    break;
                }
                else if (_userChoice == "6")
                {
                    Console.Write("\nSave file to (enter filename): ");
                    string saveFileName = Console.ReadLine();
                    SaveGame(saveFileName);
                    break;
                }
                else if (_userChoice == "7")
                {
                    Environment.Exit(0);
                    break;
                }
                else 
                {
                    Console.WriteLine("\nInvalid choice. Please select a valid option.");
                    break;
                }     
            }
        }
    }

    public void DisplayCharacterOwnerInfo()
    {
        Console.WriteLine($"\nCharacter Owner: {_userName}\n");
    }
    public void CheckHunger()
    {
        for (int i = _characters.Count - 1; i >= 0; i--)
        {
            Character character = _characters[i];
            if (character.IsDead())
            {
                character.DeathStatus();
                _characters.RemoveAt(i);
            }
        }
    }
    public void ViewCharacterStatus()
    {
        DisplayCharacterOwnerInfo();

        Console.WriteLine("\nCharacters:\n");
        for (int i = 0; i < _characters.Count; i++)
        {
            Console.Write($"Character {i + 1}: ");
            Console.WriteLine(_characters[i].CharacterDetails());
        }
    }

    public void CreateCharacter()
    {
        Console.Clear();
        Console.WriteLine("\nCharacters available:\n");
        Console.WriteLine("1. Warrior");
        Console.WriteLine("2. Archer");
        Console.WriteLine("3. Mage");
        Console.WriteLine("4. Assasin");
        Console.Write("\nWhich character would you like to create? (Type: Warrior, Archer, Mage, Assasin)\n-- ");

        string _characterType = Console.ReadLine();

        Console.Write("Enter character's name: ");
        string _characterName = Console.ReadLine();
        Console.Write("Enter a characteristic for your character: ");
        string _characteristic = Console.ReadLine();

        User newUser = new User(_userName);

        if (_characterType.Equals("Warrior", StringComparison.OrdinalIgnoreCase))
        {

            Warrior _characterCreated = new Warrior(_characterName, _characteristic);
            newUser.CreateCharacter(_characterCreated , _characterName, _characteristic);
            _characters.Add(_characterCreated);
        }
        else if (_characterType.Equals("Archer", StringComparison.OrdinalIgnoreCase))
        {
            Archer _characterCreated = new Archer(_characterName, _characteristic);
            newUser.CreateCharacter(_characterCreated , _characterName, _characteristic);
            _characters.Add(_characterCreated);
            
        }
        else if (_characterType.Equals("Mage", StringComparison.OrdinalIgnoreCase))
        {
            Mage _characterCreated = new Mage(_characterName, _characteristic);
            newUser.CreateCharacter(_characterCreated , _characterName, _characteristic);
            _characters.Add(_characterCreated);
        }
        else if (_characterType.Equals("Assasin", StringComparison.OrdinalIgnoreCase))
        {
            Assassin _characterCreated = new Assassin(_characterName, _characteristic);
            newUser.CreateCharacter(_characterCreated , _characterName, _characteristic);
            _characters.Add(_characterCreated);
        }
        else
        {
            Console.WriteLine($"\nSorry {_userName}, there's no {_characteristic} ready for adoption at the moment.");
        }
    }

    public void FeedCharacter()
    {
        Console.Clear();
        ViewCharacterStatus();
        Console.Write("\nWhich character would you like to feed? \n(Type number of corresponding pet: 1 to " + _characters.Count + "): ");
        int characterIndex = int.Parse(Console.ReadLine()) - 1;

        if (characterIndex >= 0 && characterIndex < _characters.Count)
        {
            Character selectedCharacter = _characters[characterIndex];
            User _user = new User(_userName);
            _user.FeedCharacter(selectedCharacter);
        }
        else
        {
            Console.WriteLine("Invalid character selection.");
        }
    }
    public void PlayWithCharacter()
    {
        Console.Clear();
        ViewCharacterStatus();
        Console.Write("\nWhich character would you like to play with? (1 to " + _characters.Count + "): ");
        int characterIndex = int.Parse(Console.ReadLine()) - 1;

        if (characterIndex >= 0 && characterIndex < _characters.Count)
        {
            Character selectedCharacter = _characters[characterIndex];
            User _user = new User(_userName);
            _user.PlayWithCharacter(selectedCharacter);
        }
        else
        {
            Console.WriteLine("Invalid character selection.");
        }
    }
    

    public void SaveGame(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            Console.WriteLine("\nSaving game . . .\n");
            outputFile.WriteLine(_userName);
            foreach (Character character in _characters)
            {
                outputFile.WriteLine(character.CharacterDetailsStringRepresentation());
            }
            Console.WriteLine("\nGame saved!");
        }
    }
    
    public void LoadGame(string filename)
    {
        Console.WriteLine($"\nLoading game files from {filename} . . .\n");
        _characters.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);

        if (lines.Length > 0)
        {
            _userName = lines[0];
        }

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            string type = parts[0];
            string name = parts[1];
            string characteristic = parts[2];
            int health = int.Parse(parts[3]);
            int hunger = int.Parse(parts[4]);
            int strength = int.Parse(parts[5]);

            Character character = null;

            if (type == "Warrior")
            {
                character = new Warrior(name, characteristic);
            }
            else if (type == "Archer")
            {
                character = new Archer(name, characteristic);
            }
            else if (type == "Mage")
            {
                character = new Mage(name, characteristic);
            }
            else if (type == "Assasin")
            {
                character = new Assassin(name, characteristic);
            }
            if (character!= null)
            {
                character.SetHealth(health);
                character.SetHunger(hunger);
                character.SetStrength(strength);

                _characters.Add(character);
            }
            else
            {
                Console.WriteLine("Invalid pet type encountered while loading the game.");
            }
        }
        Console.WriteLine($"Game is successfully loaded from '{filename}'.\n");
    }
}