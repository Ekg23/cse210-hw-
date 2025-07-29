using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

        MathAssignment assignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "9-18");
        string summary1 = assignment1.GetSummary();
        string homeWorkList = assignment1.GetHomeWorkList();
        Console.WriteLine(summary1);
        Console.WriteLine(homeWorkList);

        WritingAssignment assignment2 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string summary2 = assignment2.GetSummary();
        string getInfo = assignment2.GetWritingInformation();
        Console.WriteLine(summary2);
        Console.WriteLine(getInfo);

    }
}