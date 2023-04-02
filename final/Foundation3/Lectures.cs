using System;

public class Lectures : Event

{
    protected string _speaker;
    protected string _capacity;
    public Lectures(string eventType, string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress, string capacity, string speaker ): base(eventType, eventTitle,eventDescription,eventDate, eventTime, eventAddress )
    {
        _speaker = speaker;
        _capacity = capacity;
        _eventType = "Lectures";
    }

    public override void DisplayMessage()
    {
        base.DisplayMessage();
    }
    public override string GetFullMessage()
    {
        return($"{_eventType} | {_eventTitle} | {_eventDescription} | {_eventDate} | {_eventTime} | {_eventAddress.GetFullAddress()} | {_speaker} | {_capacity}");
    }

    
}