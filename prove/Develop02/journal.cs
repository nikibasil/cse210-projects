using System;  
using System.IO;  
using System.Text;

// A Journal should store a list of Entry objects. 
// The data type for this should be List<Entry>




public class Journal
{
    public List<Entry> _entryList = new List<Entry>();

    public string filename;
    // public string filename = "myfile.txt";
    // StreamReader reader = new StreamReader(filename);  
       
    // list of lists
    // public List<List<string>> _entryList = new List<List<string>>();

    public void AddEntry()
    {
        Entry _entry = new Entry();

        // entry holds input text
        _entry.Write();
        // store text data inside _entryList
        _entryList.Add(_entry);

    }

    public void enterFileName(){
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
            Console.WriteLine($"I got to diplay file,entryList count: {_entryList.Count}");
            Console.WriteLine("");
            // Console.WriteLine($"{Entry._date} ");
        }

    }

    // public void CreateFile()
    // {
    //     string path = @$ "{filename}";
    //     using (FileStream fs = File.Create(path));
    // }

    public void WriteToFile()
    {
        try
        {//Pass the filepath and filename to the StreamWriter Constructor
            StreamWriter sw = new StreamWriter("C:\\Test.txt");
                
            //// Brother Carter Says
            //// Instead of writing the line of text and the second line below
            //// Replace it with writing out the contents of your Entry class 
            // that you want to save. Ideally in one line, but you can use multiple
            //  lines as long as your read code matches and expects multiple lines
                
            //Write a line of text
            sw.WriteLine("Hello World!!");
                //Write a second line of text
            sw.WriteLine("From the StreamWriter class");
                
                //Close the file
            sw.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
                Console.WriteLine("Executing finally block.");
        }


    // }
    //  public void Save()
    // {
    //     try
    //     {  Console.WriteLine("What is your filename?" );
    //     //fileName.Append(entries);
    //         using (StreamWriter outputFile = new StreamWriter(filename))
    //         {
    //             foreach (Entry entry in _entryList)
    //             {
    //                 outputFile.WriteLine($"{entry._date}/ {entry._prompt}/ {entry._response}");
                    
    //             }
    //             outputFile.Close();
    //         }
        
    //     }
        
    //     catch(Exception e)
    //     {
    //         Console.WriteLine("Exception: " + e.Message);
    //     }
    //     finally
    //     {
    //         Console.WriteLine("Executing finally block.");
    //     }
    }


    // READING A FILE
    // public void SaveFile(string _date, string _prompt, string _response)
    public void SaveFile()
    {
        // Console.WriteLine("What is your file name? ");
        // string filename = Console.Readline();
        // string fileName = "myFile.txt";
    //    
        enterFileName();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // filename.Writeline(_response);
                  
            // You can add text to the file with the WriteLine method
            
            // {
            //     outputFile.WriteLine(_data);
            // }
            foreach (Entry entry in _entryList)
            {
                outputFile.WriteLine($"{entry._date}/ {entry._prompt}/ {entry._response}");
                 
            }

        }
        Console.WriteLine("File saved");
    }     

    
    


    
    // READING THE FILE
     public void LoadFile()
    {
        Console.WriteLine("assessing load file method");
        String line;
            try
            {    
                // StreamReader.Read method reads the next character or next set of 
                //     characters from the input stream. 
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(_fileName);
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                // while (line != null)
                while (line != null)
                {
                    
                    /// Brother Carter says Instead of Console.WriteLine below, 
                    /// create your Entry class here and populate it with the 
                    // contents of 'line'.
                    //  Console.WriteLine(line);
    //                 
                    Entry loadEntry = new Entry();
                    // _entryList = loadEntry(line);
                    
                //  /Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
    }

    // public void SaveFile()
    // {

    // }
    public string _fileName;
    public void ProcessFiles()
    {
        try{
            Console.WriteLine("Enter the file name: ");
            _fileName = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(_fileName))
        {
           
            foreach (Entry entry in _entryList)
            {
                entry.Display();
                file.WriteLine($"{entry._date} {entry._prompt} {entry._response}");
                 
            }
        }}
        // Console.WriteLine("File saved");

        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
        }
    }    



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