using System;

public class Customer
{

    private string _customerName;
    private Address _address;

    public Customer(string customerName)
    {
        _customerName = customerName;
        Console.WriteLine("Enter your address: ");
        Console.Write("Street: ");
        string street = Console.ReadLine();
        Console.Write("City: ");
        string city = Console.ReadLine();
        Console.Write("State/Province: ");
        string state = Console.ReadLine();
        Console.Write("Country: ");
        string country = Console.ReadLine();
        _address = new Address(street ,city, state, country);
    }
    public bool GetCountry()
    {
       return _address.IsUsa();
    }

    public Address GetAddress()
    {
        return _address;
    }

    public string GetName()
    {
        return _customerName;
    }
}