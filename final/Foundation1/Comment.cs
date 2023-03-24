using System;
using System.Collections.Generic;

public class Comment
{
    private string _commenterName;
    private string _commenterText;

    public Comment(string commenterName, string commenterText)
    {
        _commenterName = commenterName;
        _commenterText = commenterText;
    }

    public Comment()
    {

    }



    public void Display()
    {
       Console.Write($"Comments: {_commenterName}  {_commenterText}");

    }

    public string GetCommentText()
    {

        return _commenterText;
    }

    public string GetCommentName()
    {
        return _commenterName;
    }

    // internal int Count()
    // {
    //     throw new NotImplementedException();
    // }
}