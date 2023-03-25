using System;

public class Address
{
    private string _address;
    private string _city;
    private string _state;

    public Address(string address, string city, string state)
    {
        _address = address;
        _city = city;
        _state = state;
    }

    public string GetFullAddress()
    {
        return($"{_address} {_city} {_state}");

    }





}