using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        //asking the user for input
        Console.Write("Please enter your score: ");
        string score = Console.ReadLine();

        //converting the user's input into int
        int percent = int.Parse(score);

        string letter = "";
        string  sign = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else if (percent < 60)
        {
            letter = "F";
        }
    
        
        //Adding to signs to the letter Grade
        if (letter != "F")
        {
            if (percent % 10 >= 7)
            {
                sign = "+";
            }
            else if (percent % 10 < 3)
            {
                sign = "-";
            }

        }

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        


        Console.WriteLine($"Your letter grade is : {letter}{sign}");
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations, you passed");
        }
        else
        {
            Console.WriteLine("Sorry, better luck next time");
        }
    }   
}