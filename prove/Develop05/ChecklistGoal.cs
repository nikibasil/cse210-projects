using System;

public class ChecklistGoal : Goal
{
    // Attributes

    protected int _bonusTimes;
    protected int _bonusPoints;
    protected int _counter = 0;

    // Constructors

//    public ChecklistGoal(string _goalName, string _goalDescription, int _pointsAwarded) : base (_goalName,_goalDescription, _pointsAwarded)
//     {
//     }

    public ChecklistGoal(string goalType, string _goalName, string _goalDescription, int _pointsAwarded, int bonusPoints, int timesForBonus) : base (goalType, _goalName, _goalDescription, _pointsAwarded)
    {
        _bonusPoints = bonusPoints;
        _bonusTimes = timesForBonus;
    }

    public ChecklistGoal()
    {
    }

    public ChecklistGoal(string goalType, string goalName, string goalDescription, int pointsAwarded, bool isComplete) : base(goalType, goalName, goalDescription, pointsAwarded, isComplete)
    {
    }
    public ChecklistGoal(string goalType, string goalName, string goalDescription, int pointsAwarded, bool isComplete, int bonusPoints, int timesForBonus) : base(goalType, goalName, goalDescription, pointsAwarded, isComplete)
    {
        _bonusPoints = bonusPoints;
        _bonusTimes = timesForBonus;
    }

    public ChecklistGoal(string goalType, string goalName, string goalDescription, int pointsAwarded, bool isComplete, int bonusPoints, int counter, int timesForBonus) : base(goalType, goalName, goalDescription, pointsAwarded, isComplete)
    {
        _bonusPoints = bonusPoints;
        _bonusTimes = timesForBonus;
        _counter = counter;
    }

    // Methods

    public int GetBonusTimes()
    {
        return _bonusTimes;
    }

    

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    // public override int RecordGoal() 
    // {    
    //     _isComplete = true;
    //     return _pointsAwarded;
    // }

    // public override int GetNumber() 
    // { 
    //     return _number;
    // }  

    // public override int GetNumber() 
    // { 
    //     return _number;
    // }  
    // public override int GetCounter() 
    // { 
    //     return _counter;
    // }     
    // public override int GetCount() 
    // { 
    //     return _counter;
    // }     

    public override int RecordGoal()
    {
        Console.WriteLine("How many times have you completed the goal? ");
        int _completeTimesBonus = int.Parse(Console.ReadLine()); 
 
        // how many times we completed the goal
        _counter += _completeTimesBonus;  

       
        if (_counter >= _bonusTimes) 
        { 
            _isComplete = true;
        }
        else 
        { 
            _isComplete = false; 
        }  

        int totalPoints = _bonusPoints * _completeTimesBonus;
        return totalPoints; 
        

    }  

    public override void DisplayGoal() //child class method
    {  
        if(_isComplete == true) { 
            // Console.WriteLine($"{_counter}");
            // Console.WriteLine($"{GetBonusTimes()}");
            // Console.WriteLine($"{_bonusTimes}");
            Console.WriteLine($"[X] | {_goalName} | {_goalDescription} | -- Currently completed {_counter}/{GetBonusTimes()} ");
        }
        else 
        { 
            Console.WriteLine($"[ ] | {_goalName} | {_goalDescription} | -- Currently completed {_counter}/{GetBonusTimes()} ");
        }
    }

    public override int RecordEvent()
    {
        throw new NotImplementedException();
    }
}