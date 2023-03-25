using System;

public class Outdoors: Event
{

    protected string _weather;
    public Outdoors(string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress, string weather): base(eventTitle,eventDescription,eventDate, eventTime, eventAddress )
    {
        _weather = weather;

    }

    public string GetFullMessage()
    {
        return($"{_eventTitle}  {_eventDescription} {_eventDate} {_eventTime} {_eventAddress.GetFullAddress()} {_eventType} {_weather}");
    }










}