
using System;

public class Reflecting : Activity
{

    public string _response;
    public string _reflection;
    Spinner spinner = new Spinner();
    Random random = new Random();
    
    protected List<string> _reflectionList = new List<string>(){
        "Why was this experience meaningful to you?\n",
        "Have you ever done anything like this before?\n",
        "How did you get started?\n",
        "How did you feel when it was complete?\n",
        "What made this time different than other times when you were not as successful?\n",
        "What is your favorite thing about this experience?\n",
        "What could you learn from this experience that applies to other situations?\n",
        "What did you learn about yourself through this experience?\n",
        "How can you keep this experience in mind in the future?\n"
        };

    public Reflecting(string activityName, string description) : base(activityName, description)
    { }

    public void StartReflecting(int duration)
    {

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine(GetPrompt());
        Console.Write("\nWhen you have something in mind, press enter to continue.\n ");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience\n");
        // Count();
        // spinner.ShowSpinner();

         StartCountdown();
        // Console.WriteLine("i am finisined counting");
        Timing(duration);

        // // timer.Start();
        // while (timer.Elapsed.TotalSeconds < duration)
        // {
        //     Console.Write("> ");
        //     _listingList.Add(Console.ReadLine());
        // }
     }

     public void Timing(int duration)
    {
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < duration)
        {
            
            Console.Write("> ");
            string rlist =  _reflectionList[random.Next(_reflectionList.Count)];
            Console.Write(rlist);
            Thread.Sleep(8000);
        }
        timer.Stop();
        int listLength = _reflectionList.Count;
        // Console.WriteLine($"\nYou listed {listLength} items!");
        // relection count
        Thread.Sleep(1000);
        // Console.WriteLine("i listed items in timing method");
    }

 
}