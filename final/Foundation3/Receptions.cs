using System;

public class Receptions: Event
{
    private string _email;
    private string _rsvp;
    public Receptions(string eventType,string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress, string email, string rsvp) :base(eventTitle,eventDescription,eventDate, eventTime, eventAddress )
    {
        _email = email;
        _rsvp = rsvp;
        _eventType = "Receptions";

    }

    public override string GetFullMessage()
    {
        return($"{_eventType} | {_eventTitle} | {_eventDescription} | {_eventDate} | {_eventTime} | {_eventAddress.GetFullAddress()} | {_email} | {_rsvp}");
    }
}