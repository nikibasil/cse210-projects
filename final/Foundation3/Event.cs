using System;

public class Event
{
   
    protected string _eventTitle;
    protected string _eventDescription;
    protected string _eventDate;
    protected string _eventTime;
    protected string _eventType;
    protected  Address _eventAddress;

    public Event(string eventType,string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress )
    {
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _eventAddress = eventAddress;
        // _eventType = _eventType;
        
    }
    public Event(string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress )
    {
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _eventAddress = eventAddress;
        
        
    }
    public Event(){}


    public virtual void DisplayMessage() {}
    public string GetStandardMessage()
    {
        return($"{_eventTitle} | {_eventDescription} | {_eventDate} | {_eventTime} | {_eventAddress.GetFullAddress()}");

    }

    public string GetShortMessage()
    {
        return($" {_eventType} | {_eventTitle} | {_eventDate} ");

    }

    public virtual string GetFullMessage()
    {
        return($" {_eventType} {_eventTitle}  {_eventDescription} {_eventDate} {_eventTime} {_eventAddress.GetFullAddress()} ");
    }


}