using System;

public class Outdoors: Event
{

    protected string _weather;
    public Outdoors(string eventType,string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress, string weather): base(eventTitle,eventDescription,eventDate, eventTime, eventAddress )
    {
        _weather = weather;
        _eventType = "Outdoors";

    }

    public override string GetFullMessage()
    {
        return($"{_eventType} | {_eventTitle} | {_eventDescription} | {_eventDate} | {_eventTime} | {_eventAddress.GetFullAddress()} | {_weather}");
    }










}