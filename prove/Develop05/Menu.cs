
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
    // int _bonusCompleted;
    int _pointsAwarded;
    protected bool _isComplete;
    protected int _counter;

    public void mainMenu()
    {
        int pick = 0;
        while (pick != 6)
        {
            Console.WriteLine($"\nYou have {_totalPoints} Points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goal");
            Console.WriteLine("3. Save Goal");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            pick = int.Parse(Console.ReadLine());

            if (pick == 1)
            {
                CreateNewGoal();
            }
            else if (pick == 2)
            {
                for (int i = 0; i < goalList.Count; i++)
                {
                    // ListGoals();
                    goalList[i].DisplayGoal();

                }

            }
            else if (pick == 3)
            {

                SaveGoals();
            }
            else if (pick == 4)
            {

                LoadGoals();
                // LoadGoals(goalList);
            }
            else if (pick == 5)
            {

                RecordGoal();

            }
            else if (pick == 6)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
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

                goal.DisplayGoal();

                x++;
            }

        }
        if (notComplete.Count() == 0)
        {
            Console.WriteLine("No incomplete goals");
        }
        else
        {
            Console.Write("\nSelect the goal you want to record: ");
            int option = int.Parse(Console.ReadLine());
            option -= 1;

            _totalPoints += notComplete[option].RecordGoal();
        }
        // Console.WriteLine($"Congratulations!");
        // Console.WriteLine($"You have earned {_pointsAwarded} Points.");
    }

    public void CreateNewGoal()
    {
        int pick = 0;

        Console.WriteLine("What type of Goal would you like to create");
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Exit");
        Console.WriteLine("What type of Goal would you like to create? ");
        pick = int.Parse(Console.ReadLine());
        _goalType = pick;
        // Console.WriteLine(_goalType);
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();
        Console.WriteLine("What is your description of your goal?");
        string description = Console.ReadLine();
        Console.WriteLine("How many Points associated with this goal?");
        int points = int.Parse(Console.ReadLine());

        if (pick == 1)
        {
            SimpleGoal simple = new SimpleGoal("Simple", name, description, points);
            goalList.Add(simple);
        }
        else if (pick == 2)
        {
            EternalGoal eternal = new EternalGoal("Eternal", name, description, points);
            goalList.Add(eternal);
        }
        else if (pick == 3)
        {
            Console.WriteLine("How many times does this goal need to be accomplished for bonus points?");
            int bonusTimes = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            int bonusPoints = int.Parse(Console.ReadLine());
            ChecklistGoal checklist = new ChecklistGoal("Checklist", name, description, points, bonusPoints, bonusTimes);
            goalList.Add(checklist);

        }
        else if (pick == 4)
        {
            Console.WriteLine("Goodbye!");
        }
        else
        {
            // go back to menu
            Console.WriteLine("anything else");
        }

    }

    public void SaveGoals()
    {
        Console.Write("What is the file name? ");

        _fileName = Console.ReadLine();

        // appends to the file instead of overwriting the previous entry
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine($"{_totalPoints}");
            foreach (Goal goal in goalList)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the file name? ");
        _fileName = Console.ReadLine();
        string[] goals = System.IO.File.ReadAllLines(_fileName);
        goalList.Clear();

        _totalPoints = int.Parse(goals[0]);
        foreach (string goal in goals)
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
        }
    }
}