using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You earned {GetPoints()} points for completing '{GetShortName()}'.");
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals never complete
    }

    public override string GetDetailsString()
    {
        return $"[∞] {GetShortName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}";
    }
}