using System;

//  
//     Adding an entry
//     Displaying all the entries
//     Saving to a file
//     Loading from a file

public class Prompts {

    public string _prompt = "";
    public string _response = "";
    public string _menu = "";

    // Make sure to initialize your list to a new List before you use it.
    // public List<Job> _jobs = new List<Job>();
    public List<string> _questionPrompt = new List<string>();
    // public List<string> _randomPromp = new List<string>();
    // var list = new List<string>{ "one","two","three","four"};

    // public string 

    // list class string
    public string RandomPrompt(){
    // public void SelectPrompt(){
        
        var random = new Random(); 
        // random r = new random

        _questionPrompt.Add("Who was the most interesting person I interacted with today?");
        _questionPrompt.Add("What was the best part of my day?");
        _questionPrompt.Add("How did I see the hand of the Lord in my life today?");
        _questionPrompt.Add("What was the strongest emotion I felt today?");
        _questionPrompt.Add("If I had one thing I could do over today, what would it be?");
 
        int index = random.Next(_questionPrompt.Count);
        // int index = r.next(_questionPrompt.Count)

        string rString = _questionPrompt[index];
        _prompt = rString;
        // Console.WriteLine(list[index]);
        Console.WriteLine(_prompt);
        return _prompt;
    }

    // public string DisplayPrompt()
    // {
    //     //some code here
    //     return prompt;
    // }

    // int pick = -1;
    
    


}



