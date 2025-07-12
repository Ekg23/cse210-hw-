using System;

public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.Now;
}

public class Journal
{
    private readonly List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        _entries.Add(new Entry
        {
            Prompt = prompt,
            Response = response,
            Timestamp = DateTime.Now
        });
    }

     public void SaveToFile(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);
        foreach (var entry in _entries)
        {
            writer.WriteLine(entry.Timestamp);
            writer.WriteLine(entry.Prompt);
            writer.WriteLine(entry.Response);
            writer.WriteLine("---"); // delimiter
        }
    }
    
     public void LoadFromFile(string filename)
    {
        _entries.Clear();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        using StreamReader reader = new StreamReader(filename);
        while (!reader.EndOfStream)
        {
            string timestamp = reader.ReadLine();
            string prompt = reader.ReadLine();
            string response = reader.ReadLine();
            reader.ReadLine(); // read delimiter

            _entries.Add(new Entry
            {
                Timestamp = DateTime.Parse(timestamp),
                Prompt = prompt,
                Response = response
            });
        }
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine($"Date: {entry.Timestamp}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
