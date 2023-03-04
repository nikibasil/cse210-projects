using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapeList = new List<Shape>();

        Square sq = new Square(5,"Blue");
        Circle cir = new Circle(6,"Red");
        Rectangle rec = new Rectangle( 5, 10, "Pink");

        _shapeList.Add(sq);
        _shapeList.Add(cir);
        _shapeList.Add(rec);

        // Shape s = new Shape();

        foreach (Shape s in _shapeList)
        {
            double area = s.GetArea();
            string color = s.GetColor();

            Console.WriteLine($"the {color} shape has an area of {area}");

        }
        

        // double area = s.GetArea();
        // string color = s.GetColor();
        
        
        // Console.WriteLine($" square shape {sq.GetColor()} has an area of {sq.GetArea()}");
        // Console.WriteLine($" Circle shape {cir.GetColor()} has an area of {cir.GetArea()}");
        // Console.WriteLine($" Rectangle shape {rec.GetColor()} has an area of {rec.GetArea()}");
    }
}