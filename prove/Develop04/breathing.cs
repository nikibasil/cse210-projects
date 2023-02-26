using System;

public class Breathing : Activity {


    private string _breatheIn = "Breathe in...";  
    private string _breatheOut = "Now breathe out...";
    // private string _breathing;

    public Breathing(string activityName, string description, int duration) :base(activityName,description,duration)
    {

    }

     public Breathing(string activityName, string description) :base(activityName,description)
    {

    }
 

    public void BreathingActivity(int duration)
    {

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        DateTime currentTime = DateTime.Now;
        Console.WriteLine(duration);
        int seconds = 0;
        while (seconds < duration)
        {

            while (currentTime < endTime){
            Console.WriteLine(_breatheIn);
            currentTime = DateTime.Now;
            Thread.Sleep(3000);
            Console.WriteLine(_breatheOut);
            currentTime = DateTime.Now;
            Thread.Sleep(3000);
            seconds += 1;
            duration -=10;
            }
            break;
        }
    }

    public void StartBreathing(int duration)
    {
        int seconds = 0;
        while (seconds < duration)
        {
            Console.WriteLine();  //insert blank line to start
            for (int i = 4; i > 0; i--)
            {
                Console.Write($"{_breatheIn}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_breatheIn.Length + 2));  
                Console.Write(blank);
                seconds += 1;
            }
            Console.WriteLine($"{_breatheIn}  ");  
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{_breatheOut}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_breatheOut.Length + 2));  
                Console.Write(blank);
                seconds += 1;
            }
            Console.WriteLine($"{_breatheOut}  ");  
        }

    }  

}