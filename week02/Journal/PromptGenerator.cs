using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the most interesting thing that happened today?",
        "What are you grateful for today?",
        "What challenge did you face today and how did you handle it?",
        "What did you learn today?",
        "How are you feeling right now and why?",
        "What could you have done better today?",
        "What made you smile today?"
    };
    private Random _random = new Random();



    public string GetRandomPrompt()
    {
       
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

}