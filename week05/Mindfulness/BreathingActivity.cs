using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Breathing");  
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(4);
            Console.Write("\nBreathe out... ");
            ShowCountDown(6);
        }

        DisplayEndingMessage();
    }


    
}