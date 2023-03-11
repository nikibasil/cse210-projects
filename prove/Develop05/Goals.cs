using System;

public abstract class Goal
{
    // Attributes
    protected string _goalType;
    protected string _goalName;
    protected string _goalDescription;
    protected int _pointsAwarded;
    protected bool _isComplete;



    // Constructors
    // Simple Goal Constructor
    public Goal(string goalType, string goalName, string goalDescription, int pointsAwarded)
    {
        _goalType = goalType;
        _goalName  = goalName;
        _goalDescription = goalDescription;
        _pointsAwarded = pointsAwarded;
        _isComplete = false;
    }

    public Goal(string goalType, string goalName, string goalDescription)
    {
        _goalType = goalType;
        _goalName  = goalName;
        _goalDescription = goalDescription;
        // _isComplete = false;
    }
    //Eternal goal constructor
    // Checklist Goal Constructor
    // public Goal(string goalType, string goalName, string goalDescription,int pointsAwarded)
    // {
    //     _goalType = goalType;
    //     _goalName  = goalName;
    //     _goalDescription = goalDescription;
    //     _pointsAwarded = pointsAwarded;
    //     // _isComplete = false;
    // }
    public Goal()
    {
        
    }

    // Constructor for completed goals
    public Goal(string goalType, string goalName, string goalDescription, int pointsAwarded, bool isComplete)
    {
        _goalType = goalType;
        _goalName  = goalName;
        _goalDescription = goalDescription;
        _pointsAwarded = pointsAwarded;
        _isComplete = isComplete;
    }
    // Methods

    public virtual void DisplayGoal() //base class method
    {  
        if(_isComplete == true) { 
            Console.WriteLine($"[X] | {_goalName} | {_goalDescription}");
        }
        else 
        { 
            Console.WriteLine($"[ ] | {_goalName} | {_goalDescription}");
        }
    }

    public abstract int RecordEvent();

    // public virtual void RecordGoal()
    // {
    //      // temporary list stores incomplete goals
    //     List<Goal> notComplete = new List<Goal>(); 

    //     int x = 1;
    //     foreach (Goal goal in goalList)
    //         {
    //             if (goal.IsComplete() == false)
    //             {
    //                 notComplete.Add(goal);
    //                 Console.Write($"{x}) ");
    //                 // ListGoals();
    //                 goal.DisplayGoal();
    //                 // DisplayGoal();
    //                 x++;
    //             }
                
    //         }
    //         if (notComplete.Count() == 0)
    //         {
    //             Console.WriteLine("No incomplete goals");
    //         }
    //         else
    //         {
    //             Console.WriteLine("Select the goal you want to record");
    //             int option = int.Parse(Console.ReadLine()); 
    //             option -= 1;   
 
    //             _totalPoints += notComplete[option].RecordGoal(); 

    //         } 

        // int ask user for whiuch goal to check off
        // create variable int value returned int value = intsance of goal nin list method.record goal
        // increase total points by that vriable
        // goalist x now in brackets brcaket might want to be a variable
    // }

    
    //Getters & Setters
    public string GetName()
    {
        return _goalName;
    }
    public string GetDescription()
    {
        return _goalDescription;
    }

    public int GetPoints()
    {
        return _pointsAwarded;
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public new string GetType()
    {
        return _goalType;
    }

    public abstract int RecordGoal();

    public bool IsComplete()
    {  
        return _isComplete;
    }  

    public virtual int GetNumber()
    { 
        return 0;
    }
    public virtual int GetCount() 
    { 
        return 0;
    }
    


    // public GetStringRepresentation()
    // {

    // }

}