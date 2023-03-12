using System;

public class SimpleGoal : Goal
{
    // Attributes
   

    // Constructors
    public SimpleGoal(string type, string goalName, string goalDescription, int pointsAwarded) : base (type, goalName, goalDescription, pointsAwarded)
    {
    }

    public SimpleGoal(string type, string goalName, string goalDescription, int pointsAwarded, bool isComplete) : base (type, goalName, goalDescription, pointsAwarded, isComplete)
    {
    }

    // Methods

    public override int RecordGoal() 
    {    
        _isComplete = true;
        return _pointsAwarded;
    }

    public override string SaveGoal()
    {

        return($"{GetType()} | {GetName()} | {GetDescription()} | {GetPoints()} | {GetIsComplete()}");
    }
    

}