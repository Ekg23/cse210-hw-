using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    
    

    //getters and setters
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetName(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_description}.");
        Console.WriteLine("");
        Console.Write("How long in seconds, would you like for your session.");
        string str = Console.ReadLine();
        _duration = int.Parse(str);
        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood job!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> annimationString = new List<string>();
        annimationString.Add("|");
        annimationString.Add("/");
        annimationString.Add("-");
        annimationString.Add("\\");
        annimationString.Add("|");
        annimationString.Add("/");
        annimationString.Add("-");
        annimationString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string item = annimationString[i];
            Console.Write(item);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= annimationString.Count)
            {
                i = 0;
            }
        }    
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            
            Console.Write("\b \b");
        }
    }
}