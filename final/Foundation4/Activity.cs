using System;

public abstract class Activity{

    protected double _miles;
    protected double _minutes;
    protected double _speed;
    protected string _activityType;
    protected double _activityLength;
    protected string _activityDate;
    protected double _distance;
    public double _pace;

    // public double Pace { get; }
    // public double Pace1 { get; }
    public Activity(){}
    public Activity(string activityDate, string activityType, double activityLength)
    {
        _activityLength = activityLength;
        _activityDate = activityDate;
        _activityType = activityType;
    }

    public virtual string GetSummary()
    {
        return($"{_activityDate} {_activityType} ({_activityLength})- Distance {_distance} miles, Speed {_speed} mph, Pace: {_pace} per mile  ");

    }

    public virtual double GetDistance(){ return 0; }
    public virtual double GetSpeed(){ return 0; }
    public virtual double GetPace()
    { 
        _pace = _activityLength / _distance;
        return _pace;
    }
}