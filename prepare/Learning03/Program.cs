using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Fraction f1 = new Fraction(); // Don't pass any information to get the default values
        // Fraction f2 = new Fraction(1); // one parameter for the top and that initializes the denominator to 1
        // Fraction p3 = new Fraction(6,7); // 6/7 (using the third constructor)
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        
        // one parameter for the top and that initializes the denominator to 1
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3,4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1,3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());


    }
}