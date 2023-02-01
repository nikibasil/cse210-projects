using System;
using System.IO;
using System.Text;

// A Journal should store a list of Entry objects. 
// The data type for this should be List<Entry>

public class Journal
{
    public List<Entry> _entryList = new List<Entry>();

    // public string filename;
    public string _fileName;

    // StreamReader reader = new StreamReader(filename);  

    public void AddEntry()
    {
        Entry _entry = new Entry();

        // entry holds input text
        _entry.Write();
        // store text data inside _entryList
        _entryList.Add(_entry);


    }

    public void enterFileName()
    {
        Console.WriteLine("File saved");
    }

    public void DisplayFile()
    {
        Console.WriteLine(_entryList.Count);
        // calls display menthod from entry class
        foreach (Entry entry in _entryList)
        {
            // displays every item inside _entryList            
            entry.Display();
            // Console.WriteLine($"entryList count: {_entryList.Count}");
            Console.WriteLine("");
            // Console.WriteLine($"{Entry._date} ");
        }

    }


// string filename = "myFile.txt";
// string[] lines = System.IO.File.ReadAllLines(filename);

// foreach (string line in lines)
// {
//     string[] parts = line.Split(",");

//     string firstName = parts[0];
//     string lastName = parts[1];
// }

    // public void Load()
    // {
    //     Console.WriteLine("What file do you want to load? ");
    //     _fileName = Console.ReadLine();
    //     string[] lines = System.IO.File.ReadAllLines(_fileName);
    //     foreach (string line in lines)
    //     {
    //         Console.WriteLine(line);
    //     }
    // }

    // miguels
    public void Load()

    {

        Console.WriteLine("What is the file name? ");

        _fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)

        {

            Console.WriteLine(line);

        }

    }

// miguels save

    public void Save()

    {

        Console.WriteLine("What is the file name? ");

        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))

            foreach (Entry _entry in _entryList)

            {

                outputFile.WriteLine($"Date: {_entry._date} - Prompt: {_entry._prompt} \n{_entry._response}\n");

            }

    }
}
    // Console.WriteLine("assessing load file method");

    // // LOAD THE FILE
    // public void LoadFile(string _fileName)
    // {
    //     Console.WriteLine("assessing load file method");
    //     String line;
    //     try
    //     {
    //         // StreamReader.Read method reads the next character or next set of 
    //         //     characters from the input stream. 
    //         //Pass the file path and file name to the StreamReader constructor
    //         using (StreamReader sr = new StreamReader(_fileName))
    //         {
    //             line = sr.ReadLine();
    //             while (line != null)
    //             {

    //                 /// Brother Carter says Instead of Console.WriteLine below, 
    //                 /// create your Entry class here and populate it with the 
    //                 // contents of 'line'.
    //                 //  Console.WriteLine(line);





    //                 //  /Read the next line
    //                 line = sr.ReadLine();
    //             }

    //         }
    //         //Read the first line of text

    //         // line = sr.ReadLine();
    //         //Continue to read until you reach end of file

    //         _entryList.Clear();
    //         // for x in range 1-3
    //         // 
    //         Entry loadEntry = new Entry();


    //         //close the file
    //         sr.Close();
    //         Console.ReadLine();
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine("Exception: " + e.Message);
    //     }
    //     finally
    //     {
    //         Console.WriteLine("Executing finally block.");
    //     }
    // }



//     public void SaveFile()
//     {
//         try
//         {
//             Console.WriteLine("Enter the file name: ");
//             _fileName = Console.ReadLine();

//             using (StreamWriter file = new StreamWriter(_fileName))
//             {

//                 foreach (Entry entry in _entryList)
//                 {

//                     file.WriteLine($"{entry._date}");
//                     file.WriteLine(entry._prompt);
//                     file.WriteLine(entry._response);
//                 }
//             }
//         }
//         // Console.WriteLine("File saved");

//         catch (Exception e)
//         {
//             Console.WriteLine("Exception: " + e.Message);
//         }
//         finally
//         {
//             Console.WriteLine("Executing finally block.");
//         }
//     }
// }



// Progress 4 
//     public string _fileName;

//    private void ProcessFile()
//     {
//             console.wrilteline("enter file name");
//             _fileName - Console.ReadLine()

//             using (StreamWriter outputFile = new StreamWriter(filename))
//             {
//                 foreach (Entry _entries in _entryList)
//                 {

//                     Entry.display();

//                 file.writleline($"{Entry._date} {Entry._prompt}{Entry._reponse}");
//                 }
//             }
//             Console.writleline("file saved");
//     }


// ---write---
// try
//             {
//                 //Pass the filepath and filename to the StreamWriter Constructor
//                 StreamWriter sw = new StreamWriter("C:\\Test.txt");

//                 //// Brother Carter Says
//                 //// Instead of writing the line of text and the second line below
//                 //// Replace it with writing out the contents of your Entry class that you want to save
//                 //// Ideally in one line, but you can use multiple lines as long as your read
//                 //// code matches and expects multiple lines

//                 //Write a line of text
//                 sw.WriteLine("Hello World!!");
//                 //Write a second line of text
//                 sw.WriteLine("From the StreamWriter class");

//                 //Close the file
//                 sw.Close();
//             }
//             catch(Exception e)
//             {
//                 Console.WriteLine("Exception: " + e.Message);
//             }
//             finally
//             {
//                 Console.WriteLine("Executing finally block.");
//             }
















//  using System;
// public class Resume
// {   
//     public string _name = "";
//     // Make sure to initialize your list to a new List before you use it.
//     public List<Job> _jobs = new List<Job>();
//     // public Resume()
//     public void DisplayJobDetails()
//     {
//         Console.WriteLine($"Name: {_name}");
//         Console.WriteLine("Jobs:");
//         // Notice the use of the custom data type "Job" in this loop
//         foreach (Job job in _jobs) 
//         {   
//              // This calls the Display method on each job
//             job.DisplayJobDetails();
//         }

//     }
// }