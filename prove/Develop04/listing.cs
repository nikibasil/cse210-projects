using System;

public class Listing : Activity
{
     
    private List<string> _listingList = new List<string>();

    public Listing(string activityName, string description, int duration) :base(activityName,description,duration)
    {
    }

    public Listing(string activityName, string description) :base(activityName,description)
    {
    }

    public void ListingActivity(int duration)
    {
        Console.WriteLine("\nList as many responses as you can:\n");
        Console.WriteLine(GetPrompt());
        
        StartCountdown();
        Timing(duration);      
    }

    public void Timing(int duration)
    {
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < duration)
        {
            Console.Write("> ");
            _listingList.Add(Console.ReadLine());
        }
        timer.Stop();
        int listLength = _listingList.Count;
        Console.WriteLine($"\nYou listed {listLength} items!");
        Thread.Sleep(1000);
        // Console.WriteLine("i listed items in timing method");
    }
    






}