class Journal
{
    private List<Entry> entries = new List<Entry>();
    private PromptGenerator promptGenerator = new PromptGenerator();
    
    public void WriteNewEntry()
    {
        Entry newEntry = new Entry
        {
            Date = DateTime.Now.ToShortDateString(),
            Prompt = promptGenerator.GetRandomPrompt()
        };

        Console.WriteLine("Your prompt: " + newEntry.Prompt);
        Console.Write("Enter your response: ");
        newEntry.Response = Console.ReadLine();

        entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveJournalToFile()
    {
        Console.Write("Enter the filename to save the journal: ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }

        Console.WriteLine("Journal saved to file successfully!");
    }

    public void LoadJournalFromFile()
    {
        Console.Write("Enter the filename to load the journal: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            entries.Clear();

            string[] lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                string[] parts = line.Split(',');
                Entry loadedEntry = new Entry
                {
                    Date = parts[0],
                    Prompt = parts[1],
                    Response = parts[2]
                };
                entries.Add(loadedEntry);
            }

            Console.WriteLine("Journal loaded from file successfully!");
        }
        else
        {
            Console.WriteLine("File not found. Please make sure the file exists.");
        }
    }
}