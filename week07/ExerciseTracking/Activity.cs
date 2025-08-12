using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime Date()
    {
        return _date;
    } 
    public int GetMinutes()
    {
        return _minutes;
    }  

    public abstract double GetDistance(); // km
    public abstract double GetSpeed();    // km/h
    public abstract double GetPace();     // min/km

    public abstract string GetSummary();
    
}