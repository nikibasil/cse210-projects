using System;

public class Action
{
    protected string _actitivtyType;
    List<Activity> activityList = new List<Activity>();

    public void CreateNewActivity()
    {
        int pick = 0;
        while (pick != 4)
        {
            Console.WriteLine("Which activity would you like to record?");
            // Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Running");
            Console.WriteLine("2. Biking");
            Console.WriteLine("3. Swimming");
            Console.WriteLine("4. Exit");
            pick = int.Parse(Console.ReadLine());
            
            Console.WriteLine("How many minutes of this activity did you complete?");
            double _activityLength = double.Parse(Console.ReadLine());
            

            if (pick == 1)
            {
                Console.WriteLine("How many miles did you run?");
                double _distance = double.Parse(Console.ReadLine());
                _actitivtyType = "Running";
                Running running = new Running("03 Nov 2022", _actitivtyType, _activityLength , _distance);
                activityList.Add(running);
                Console.WriteLine(running.GetSummary());             
            }
            else if (pick == 2)
            {
                Console.WriteLine("What was your cycling speed in miles per hour?");
                double _speed = double.Parse(Console.ReadLine());
                _actitivtyType = "Biking";
                Biking biking = new Biking("14 Apr", _actitivtyType, _activityLength, _speed);
                activityList.Add(biking);
                Console.WriteLine(biking.GetSummary());
            }
            else if (pick == 3)
            {
                _actitivtyType = "Swimming";
                Console.WriteLine("How many laps did you complete?");
                int _swimmingLaps = int.Parse(Console.ReadLine());
                Swimming swimming = new Swimming("04 March 2023", _actitivtyType, _activityLength, _swimmingLaps);
                activityList.Add(swimming);
                Console.WriteLine(swimming.GetSummary());
            
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
            
            // Activity activity = new Activity();
            // Console.WriteLine(GetSummary());
        }

    }

    
}