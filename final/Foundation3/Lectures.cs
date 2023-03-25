using System;

public class Lectures : Event

{
    protected string _speaker;
    protected string _capacity;
    public Lectures(string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress, string capacity, string speaker ): base(eventTitle,eventDescription,eventDate, eventTime, eventAddress )
    {
        _speaker = speaker;
        _capacity = capacity;
        _eventType = "Lectures";
    }

    public string GetFullMessage()
    {
        return($"{_eventTitle}  {_eventDescription} {_eventDate} {_eventTime} {_eventAddress.GetFullAddress()} {_eventType} {_speaker} {_capacity}");
    }

    // public string GetStandardMessage()
    // {
    //     return($"{_eventTitle}  {_eventDescription} {_eventDate} {_eventTime} {_eventAddress.GetFullAddress()}");

    // }

}