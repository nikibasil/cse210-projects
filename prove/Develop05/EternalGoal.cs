using System;

public class EternalGoal : Goal
{
    // Attributes

    // Constructors
//    public EternalGoal(string _goalName, string _goalDescription, int _pointsAwarded) : base (_goalName,_goalDescription, _pointsAwarded)
//    {

//    }

   public EternalGoal(string goalType, string goalName, string goalDescription, int pointsAwarded) : base (goalType, goalName,goalDescription,pointsAwarded)
   {

   }

    public override int RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override string SaveGoal()
    {
        return ($"{GetType()} | {GetName()} | {GetDescription()} | {GetPoints()}");
    }

    // Methods
    public override int RecordGoal() 
    {    
        return _pointsAwarded;
    }
    

}