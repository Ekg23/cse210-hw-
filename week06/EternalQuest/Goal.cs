using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;
    //getters
    public string GetShortName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetPoints()
    {
        return _points;
    }

    //constructor
    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
    public string GetPointsValue()
    {
    return _points; 
    }
    
    
}