using System;

public class EternalGoal : Goal
{
    // Attributes

    // Constructors

   public EternalGoal(string goalType, string goalName, string goalDescription, int pointsAwarded) : base (goalType, goalName,goalDescription,pointsAwarded)
   {

   }

    // Methods
    public override string SaveGoal()
    {
        return ($"{GetType()} | {GetName()} | {GetDescription()} | {GetPoints()}");
    }
   
    public override int RecordGoal() 
    {    
        return _pointsAwarded;
    }
    // public override void RecordGoal(List<Goal> goals)
    // {
    //    Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    // }
    

}