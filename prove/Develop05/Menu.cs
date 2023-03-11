
using System;
using System.IO;
using System.Text;

public class Menu
{
    List<Goal> goalList = new List<Goal>();
    // string _username;
    int _totalPoints = 0;
    public string _fileName;
    public int _goalType;
    int _bonusCompleted;
    protected bool _isComplete;

    public void mainMenu()
    {
        int pick = 0;
        while (pick != 6)
        {
            Console.WriteLine("Menu Options:");  
            Console.WriteLine("1. Create New Goal"); 
            Console.WriteLine("2. List Goal");
            Console.WriteLine("3. Save Goal");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            pick = int.Parse(Console.ReadLine());

            if (pick == 1){
                CreateNewGoal();                
            }
            else if (pick  == 2){
                for(int i = 0; i < goalList.Count; i++) 
                {
                    // ListGoals();
                    goalList[i].DisplayGoal();
                }
            }
            else if (pick  == 3){
              
                SaveGoals();
               
            }    
            else if (pick  == 4){
                
                LoadGoals();
                // LoadGoals(goalList);
            }    
            else if (pick  == 5){
                
                RecordGoal();              
            }                
            else if (pick  == 6){
                Console.WriteLine("Goodbye!");
            }
            else {
                // go back to menu
                break;
                // Console.WriteLine("anything else");
            }
        }
    }

    public void RecordGoal()
    {
         // temporary list stores incomplete goals
        List<Goal> notComplete = new List<Goal>(); 

        int x = 1;
        foreach (Goal goal in goalList)
            {
                if (goal.IsComplete() == false)
                {
                    notComplete.Add(goal);
                    Console.Write($"{x}) ");
                    // ListGoals();
                    goal.DisplayGoal();
                    // DisplayGoal();
                    x++;
                }
                
            }
            if (notComplete.Count() == 0)
            {
                Console.WriteLine("No incomplete goals");
            }
            else
            {
                Console.WriteLine("Select the goal you want to record");
                int option = int.Parse(Console.ReadLine()); 
                option -= 1;   
 
                _totalPoints += notComplete[option].RecordGoal(); 

            } 

        // int ask user for whiuch goal to check off
        // create variable int value returned int value = intsance of goal nin list method.record goal
        // increase total points by that vriable
        // goalist x now in brackets brcaket might want to be a variable
    }

    public void CreateNewGoal()
    {
        int pick = 0;

        Console.WriteLine("What type of Goal would you like to create");
        // while (pick != 4)
        // {


            Console.WriteLine("The types of goals are:");  
            Console.WriteLine("1. Simple Goal"); 
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Exit");
            Console.WriteLine("What type of Goal would you like to create? ");
            pick = int.Parse(Console.ReadLine());
            _goalType = pick;
            Console.WriteLine(_goalType);

            if (pick == 1){
                             
                Console.WriteLine("What is the name of your goal?");
                string name = Console.ReadLine();
                Console.WriteLine("What is your description of your goal?");
                string description = Console.ReadLine();
                Console.WriteLine("How many Points associated with this goal?"); 
                int points = int.Parse(Console.ReadLine());
                SimpleGoal simple = new SimpleGoal("Simple",name, description, points);
                goalList.Add(simple);  
                      
            }
            else if (pick  == 2){
                Console.WriteLine("What is the name of your goal?");
                string name = Console.ReadLine();
                Console.WriteLine("What is your description of your goal?");
                string description = Console.ReadLine();
                Console.WriteLine("How many Points associated with this goal?"); 
                int points = int.Parse(Console.ReadLine());
                EternalGoal eternal = new EternalGoal("Eternal", name, description, points);
                goalList.Add(eternal);
            }
            else if (pick  == 3){
                Console.WriteLine("What is the name of your goal?");
                string name = Console.ReadLine();
                Console.WriteLine("What is your description of your goal?");
                string description = Console.ReadLine();
                Console.WriteLine("How many Points associated with this goal?"); 
                int points = int.Parse(Console.ReadLine());
                Console.WriteLine("How many times does this goal need to be accomplished for bonus points?");
                int bonusTimes = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for accomplishing it that many times?");
                int bonusPoints = int.Parse(Console.ReadLine());
                ChecklistGoal checklist = new ChecklistGoal("Checklist", name, description, points, bonusPoints, bonusTimes);
                goalList.Add(checklist);
                
            }            
            else if (pick  == 4){
                Console.WriteLine("Goodbye!");
            }
            else {
                // go back to menu
                Console.WriteLine("anything else");
            }
        // }


    } 

    public void ListGoals()
        {
            foreach (Goal goal in goalList)
            {
                if (_goalType == 3 && _isComplete == true)
                {
                    ChecklistGoal checklistg = new ChecklistGoal();
                    Console.WriteLine($"[X]{goal.GetName()} ({goal.GetDescription()}) -- Currently completed{_bonusCompleted}/{checklistg.GetBonusTimes()}");
                }
                else if(_goalType == 3 && _isComplete == false)

                {
                    ChecklistGoal checklistg = new ChecklistGoal();
                    Console.WriteLine($"[]{goal.GetName()} ({goal.GetDescription()}) -- Currently completed{_bonusCompleted}/{checklistg.GetBonusTimes()}");
                }
                // else if(_goalType == 3 && _isComplete == true){
                //     Console.WriteLine($"[X]{goal.GetName()} ({goal.GetDescription()})");
                // }
                
                else if(_goalType != 3 && _isComplete == false)
                {     
                    Console.WriteLine($"[]{goal.GetName()} ({goal.GetDescription()})");

                }

            }
            Console.WriteLine($"\nYou have {_totalPoints} Total Points!\n");
        }   
    
    public void SaveGoals()
    {
        Console.WriteLine("What is the file name? ");

        _fileName = Console.ReadLine();

        // appends to the file instead of overwriting the previous entry
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine($"{_totalPoints}");
            foreach (Goal goal in goalList)
            {
                if (goal.GetType() == "Simple")
                {
                    outputFile.WriteLine($"{goal.GetType()} | {goal.GetName()} | {goal.GetDescription()} | {goal.GetPoints()} | {goal.GetIsComplete()}");
                
                }
                else if(goal.GetType() == "Eternal")
                {
                    outputFile.WriteLine($"{goal.GetType()} | {goal.GetName()} | {goal.GetDescription()} | {goal.GetPoints()}");
                }
                else{
                    ChecklistGoal checklist = new ChecklistGoal();
                    outputFile.WriteLine($"{goal.GetType()} | {goal.GetName()} | {goal.GetDescription()} | {goal.GetPoints()} | {goal.GetIsComplete()} | {checklist.GetBonusPoints()} | {checklist.GetCount()} | {checklist.GetBonusTimes()}");
                    Console.WriteLine($"{goal.GetType()} | {goal.GetName()} | {goal.GetDescription()} | {goal.GetPoints()} | {goal.GetIsComplete()} | {checklist.GetBonusPoints()} | {checklist.GetCount()} | {checklist.GetBonusTimes()}");
                }
                
            }
        }
    }

// consider creating a method that returns a 
// string containing the pieces of data that you need for your 
// object, such as: GetStringRepresentation(). This might 
// include the type of the object first (so you'll know later 
// which one you // should be using), and then any details of 
// the object.
    // public void LoadGoals(List<Goal> goals)
    public void LoadGoals()
    {
        Console.WriteLine("What is the file name? ");
        _fileName = Console.ReadLine();
        // string[] parts = System.IO.File.ReadAllLines(_fileName);
        string[] goals = System.IO.File.ReadAllLines(_fileName);
        goalList.Clear();
        
        _totalPoints = int.Parse(goals[0]);
        foreach(string goal in goals)
        {
            string[] lines = goal.Split(" | ");
            
            if (lines[0] == "Simple")
            {
                //type,name,desc,awardedpoints,completed
                SimpleGoal simplegoal = new SimpleGoal(lines[0], lines[1], lines[2], int.Parse(lines[3]), bool.Parse(lines[4]));
                goalList.Add(simplegoal);
            }

            else if (lines[0] == "Eternal")
            {
                //type,name,desc,awardedpoints
                EternalGoal eternalgoal = new EternalGoal(lines[0], lines[1], lines[2], int.Parse(lines[3]));
                goalList.Add(eternalgoal);
            }
            else if (lines[0] == "Checklist")
            {
                //type,name,desc,awardedpoints,bonusp,bonustimes
                ChecklistGoal checklistgoal = new ChecklistGoal(lines[0], lines[1], lines[2], int.Parse(lines[3]), bool.Parse(lines[4]), int.Parse(lines[5]), int.Parse(lines[6]), int.Parse(lines[7]));
                goalList.Add(checklistgoal);          
        }
        
        // for (int x = 0; x < lines.Count(); x += 3)
        // {
        //     Goal goal = new Goal();
        //     goal.GetPoints = lines[x];
        //     goal.GetName = lines[x+1];
        //     goal.GetDescription = lines[x+2];
        //     goalList.Add(goal);
        // }
    }






}

}         