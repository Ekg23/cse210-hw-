using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        return (GetSpeed() * GetMinutes()) / 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
    
    public override string GetSummary()
    {
        return $"{Date():dd MMM yyyy} Cycling ({GetMinutes()} min): " +
               $"Distance {GetDistance():0.0} km, " +
               $"Speed {GetSpeed():0.0} kph, " +
               $"Pace: {GetPace():0.00} min per km";
    } 
    
}