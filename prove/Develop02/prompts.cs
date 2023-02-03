using System;

public class Prompts {

    public string _prompt = "";
    public string _response = "";
    public string _menu = "";

    // Make sure to initialize your list to a new List before you use it.
    // public List<Job> _jobs = new List<Job>();
    public List<string> _questionPrompt = new List<string>();
       
    public string RandomPrompt(){
            
        var random = new Random(); 
        
        _questionPrompt.Add("Who was the most interesting person I interacted with today? ");
        _questionPrompt.Add("What was the best part of my day? ");
        _questionPrompt.Add("How did I see the hand of the Lord in my life today? ");
        _questionPrompt.Add("What was the strongest emotion I felt today? ");
        _questionPrompt.Add("If I had one thing I could do over today, what would it be? ");
 
        int index = random.Next(_questionPrompt.Count);
        
        string rString = _questionPrompt[index];
        _prompt = rString;
        // Console.WriteLine(list[index]);
        // Console.WriteLine(_prompt);
        return _prompt;
    }
    
}



