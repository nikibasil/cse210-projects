using System;

public class MathAssignment : Assignment
{

    private string _section;
    private string _problems;

    public MathAssignment(string studentName, string topic, string section, string problems) : base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }

    // public MathAssignment() : base()
    // {

    // }

    

    // public MathAssignment(string section, string problems)
    // {
    //    _section =  section;
    //    _problems = problems; 
    // }

    public string DisplayMathHomework()
    {
        
        return $"Section {_section} Problems {_problems}";
    }


}