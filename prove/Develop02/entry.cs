 using System;
//  responsibility to hold data

public class Entry{

    public string _date;
    public string _prompt;
    public string _response;
    // private List<string> _data = new List<string>();
 // member variable for each key part
    public Entry()
    {
    }
    public void Write(){
        // _date = DateTime.Today;
        _date = DateTime.Now.ToString();
        // Console.WriteLine(_date);
        
        Prompts prompt = new Prompts();
        _prompt = prompt.RandomPrompt();
        // string displayPrompt = prompt.Display();
        // Console.WriteLine(displayPrompt);
        // Console.Write(_prompt);

        _response = Console.ReadLine();

        // _data.Add(_date);
        // _data.Add(_prompt);
        // _data.Add(_response);
    }
    // public List<string> getData()
    // {
    //     // return _data; 
    // }
    public void Display() {
        // Console.Write("Date: ");
        // Console.WriteLine(_date,_prompt,_response);
        // Console.WriteLine(_data);
        Console.WriteLine($"I got to entry display:");
        Console.Write($"Date: ");
        Console.WriteLine(_date);
        Console.Write(_prompt);
        Console.Write(_response);
        // Console.WriteLine(_data);
    }

}








 