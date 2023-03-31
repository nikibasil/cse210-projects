using System;

public class Biking : Activity
{

    public Biking(string activityDate, string actitivtyType, double activityLength, double speed) : base(activityDate, actitivtyType, activityLength)
    {
        _speed = speed;
    }


    public override double GetDistance()
    {
        _distance = _speed * _activityLength;
        return _distance;
    }

    // public override double GetPace(double _distance, double _activityLength)
    public override double GetPace()
    {
        _pace = _activityLength / GetDistance();
        return _pace;
    }

    public override string GetSummary()
    {
        return($"{_activityDate} {_activityType} ({_activityLength}min) - Distance {GetDistance()} miles, Speed {_speed} mph, Pace: {GetPace()} min per mile\n");
    }

}