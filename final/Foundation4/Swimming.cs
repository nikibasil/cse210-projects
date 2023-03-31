using System;

public class Swimming : Activity
{
    private int _swimmingLaps;

    public Swimming(string activityDate, string actitivtyType, double activityLength, int swimmingLaps) : base(activityDate, actitivtyType, activityLength)
    {
        _swimmingLaps = swimmingLaps;
    }

    public override double GetDistance()
    {
       _distance = _swimmingLaps * 50 / 1000 * 0.62;
       return _distance;
     
    }

    public override double GetSpeed()
    {
        _speed = GetDistance() / _activityLength * 60;
        return _distance;
    }
    
    public override double GetPace()
    {
        _pace = _activityLength / GetDistance();
        return _pace;
    }

    public override string GetSummary()
    {
        return($"{_activityDate} {_activityType} ({_activityLength}min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }
    




    
}