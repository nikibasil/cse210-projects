using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Scripture scripture = new Scripture("Alma", "1", "17", null, "If any of you lack wisdom, let him ask of God, that cgiveth to all men liberally, and dupbraideth not; and it shall be given him. But let him aask in bfaith, nothing cwavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.");
        scripture.HideWords();
    }
}


// public string  RandomScript(){
//     string[] allScriptures = System.IO.File.ReadAllLines("script.txt");
//     Random rand = new Random();
//     // _scriptString = allScriptures[rand.Next(allScriptures.Length)];
//     _scriptString = allScriptures[1];
//     return _scriptString;
// }