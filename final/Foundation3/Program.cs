using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Events Program.");
        ProcessEvent process = new ProcessEvent();
        process.GetMainMenu();
        
    }
}