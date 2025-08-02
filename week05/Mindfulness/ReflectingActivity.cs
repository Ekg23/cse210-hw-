using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompt = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() 
    {
        SetName("Reflection");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience.");
    }
    

    public void Run()
    {
        
        DisplayStartingMessage();
        Random rand = new();
        Console.WriteLine("\nPrompt: " + _prompt[rand.Next(_prompt.Count)]);
        Console.WriteLine("Reflect on the following questions:\n");

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("> " + _questions[rand.Next(_questions.Count)]);
            Console.WriteLine();
            ShowSpinner(5);
        }

        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        Random rand = new();
        return _prompt[rand.Next(_prompt.Count)];

    }

    public string GetRandomQuestions()
    {
        Random rand = new();
        string question = _questions[rand.Next(_questions.Count)];
        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestion()
    {
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        int timePerQuestion = GetDuration() / 3;
        if (timePerQuestion < 2) timePerQuestion = 2;
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"\n{GetRandomQuestions()} ");
            ShowSpinner(timePerQuestion);
        }  
    }
}
