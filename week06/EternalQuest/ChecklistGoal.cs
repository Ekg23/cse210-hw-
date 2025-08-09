public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _bonusPoints;
    private int _currentCount; // ✅ Needed for SetProgress()

    public ChecklistGoal(string name, string description, string points, int targetCount, int bonusPoints) 
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public int GetBonusValue()
    {
        return _bonusPoints;
    }

    public int GetProgress()
    {
        return _currentCount;
    }

    public int GetTargetCount()
    {
        return _targetCount;
    }

    

    public override void RecordEvent()
    {
        _currentCount++;
        Console.WriteLine($"Progress: {_currentCount}/{_targetCount}");

        if (_currentCount >= _targetCount)
        {
            Console.WriteLine($"You earned {GetPoints()} points plus a bonus of {_bonusPoints}!");
        }
        else
        {
            Console.WriteLine($"You earned {GetPoints()} points!");
        }
    }

    public void SetProgress(int completedCount)
    {
        _currentCount = completedCount; // ✅ Now works
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetDetailsString()
    {
        return $"[Checklist] {GetShortName()} ({GetDescription()}) -- Currently completed {_currentCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_targetCount}|{_bonusPoints}|{_currentCount}";
    }
}