using System;

public class Running : Activity
{
    public Running()
    {
    }

    public Running(string activityDate, string actitivtyType, double activityLength, double distance) : base(activityDate, actitivtyType, activityLength)
    {
      _distance = distance;
    }

    public override double GetSpeed()
    {
        _speed = (_distance / _activityLength) * 60;
        return _speed;
    }

    public override string GetSummary()
    {
        return($"{_activityDate} {_activityType} ({_activityLength}min) - Distance {_distance} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile\n  ");

    }
}