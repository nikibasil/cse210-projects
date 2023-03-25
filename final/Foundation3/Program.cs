using System;


class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");
        Address address = new Address("335", "rexburg", "Idaho");
        Lectures l = new Lectures("a", "b", "c", "d", address, "45", "joe");
        Console.WriteLine(l.GetStandardMessage());
        Console.WriteLine(l.GetShortMessage());
        Console.WriteLine(l.GetFullMessage());
        Event e = new Event("a", "b", "c", "d", address);
        Console.WriteLine(e.GetStandardMessage());
        Console.WriteLine(e.GetShortMessage());
        // Console.WriteLine(e.GetFullMessage());
    }
}