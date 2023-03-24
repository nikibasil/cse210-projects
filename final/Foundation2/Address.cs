using System;

public class Address{

    private string _address;
    private string _city;
    private string _state;
    private string _country;

    public Address(string address, string city, string state, string country )
    {
        _address = address;
        _city = city;
        _state = state;
        _country = country;        
    }

    public bool IsUsa()
    { 

       if (_country.ToUpper() == "USA")
       {
            return true;
       }
       return false;
    }

    public string GetAddress()
    {
        return ($"Street: {_address}\nCity: {_city}\nState/Prov: {_state}\nCountry: {_country}");

    }
}