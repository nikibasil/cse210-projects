using System;
using System.Collections.Generic;

public class Video
{

    public string _title;
    // { get; set; }
    public int _seconds;
    //  { get; set; }
    public string _author;
    public int _commentCount;
    private List<Comment> _comments = new List<Comment>();
    
    
    
    public void AddComments(string commenterName, string commenterText)
    {

        Comment comment = new Comment(commenterName,commenterText);
        _comments.Add(comment);
        _commentCount = _comments.Count;

    }

    public void DisplayVideoDetails()  
    {

        Console.WriteLine($"\nTitle: {_title}, Seconds: {_seconds}, Author: {_author} ");
        Console.WriteLine($"{_commentCount} Comments:");
       
        foreach(Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetCommentName()} - {comment.GetCommentText()} ");
        }
         
               
    }
}


