using System;

public abstract class Goal
{
    // Attributes
    // List<Goal> goalList = new List<Goal>();
    protected string _goalType;
    protected string _goalName;
    protected string _goalDescription;
    protected int _pointsAwarded;
    protected bool _isComplete;
    public string _fileName;
    protected int _totalPoints;

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

        // Console.WriteLine($"You have {_totalPoints}!");
    }

    
    // public abstract int RecordEvent();
    public abstract string SaveGoal();

       
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

}