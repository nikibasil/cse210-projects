using System;

public class Activity{

    private string _activityName;
    protected int _duration;
    private string _description;
    private string __prepareMessage;
    protected DateTime _endTime;
    Random random = new Random();
    
    private List<string> _questionPrompt = new List<string>(){
        "Who are people that you appreciate? ",
        "What are personal strengths of yours? ",
        "Who are people that you have helped this week? ",
        "When have you felt the Holy Ghost this month? ",
        "Who are some of your personal heroes? "
    };
    protected string _endMessage;
    public Activity(string activityName,  string description, int duration){
       _activityName = activityName;
       _duration = duration;
       _description = description; 

    }

    public Activity(string activityName,  string description){
       _activityName = activityName;
       
       _description = description; 

    }

    public Activity(string activityName, string description, string prepareMessage)
    {
        _activityName = activityName;
        _description = description;
        __prepareMessage = prepareMessage;
    }

    public Activity()
    {
    }

    // public Activity(string v1, string v2)
    // {
    //     this.v1 = v1;
    //     this.v2 = v2;
    // }

    public string GetActivity(){
        Console.Clear();
        return $"Welcome to the {_activityName} Activity.\n\n{_description} \n ";
        
    }

    public string GetPrompt()
    {
        return _questionPrompt[random.Next(_questionPrompt.Count)];
    }
    public void EndTime(){
        _endTime = DateTime.Now.AddSeconds(_duration);

    }

    public bool RemainingTime(){

        if (DateTime.Now < _endTime){
            return true;
        }
        else{
            return false;
        }
    } 

    public int GetDuration(){

        Console.Write("How long in seconds would you like for your session? ");
        int duration = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Get ready...");
        _duration = duration;
        // Console.WriteLine(duration);
        return duration;
        
    }

    public void GetReady()
    {
        Console.Clear();
        Spinner spinner = new Spinner();
        spinner.ShowSpinnerReady();
    }

    public void Count()
    {
        Console.WriteLine();  
        string _message = "You may begin in ";
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"{_message}{i}");
            Thread.Sleep(1000);
            string blank = new string('\b', (_message.Length + 2));  
            Console.Write(blank);
        }
        Console.WriteLine($"Go:                               ");  
    }

  
    public void StartCountdown()
    {
        Console.WriteLine();  //insert blank line to start
    
        Thread.Sleep(300);
        Console.WriteLine($"Start Now:                               ");  // last prompt
    }

    

    public void EndMessage(){
        Spinner spinner = new Spinner();
        spinner.ShowSpinnerDone();
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_activityName} Activity!");
        Thread.Sleep(5000);
        // spinner.ShowSpinner();
        Console.Clear();

    }


}   

