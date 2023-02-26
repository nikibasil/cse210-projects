using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");

        Assignment assign1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assign1.GetSummary());

        MathAssignment assign2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3","8-19" );
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.DisplayMathHomework());

        WritingAssignment assign3 = new WritingAssignment("Mary Waters","European History", "The Causes of World War II");
        Console.WriteLine(assign3.GetSummary());
        Console.WriteLine(assign3.GetWritingInfo());   

        // Book book1 = new Book();
        // book1.SetAuthor("Smith");
        // book1.SetTitle("My new book");

        // Console.WriteLine(book1.GetBookInfo());

        // PictureBook book2 = new PictureBook();
        // book2.SetAuthor("Jones");
        // book2.SetTitle("A wonderful picture book");
        // book2.SetIllustrator("Daisy");

        // Console.WriteLine(book2.GetBookInfo());
        // Console.WriteLine(book2.GetPictureBookInfo());

        // Book book3 = new Book("Edwards", "Another Book");
        // Console.WriteLine(book3.GetBookInfo());

        // PictureBook book4 = new PictureBook("Edwards", "Another Book", "Illustrator Name");
        // Console.WriteLine(book4.GetBookInfo());

    }
}