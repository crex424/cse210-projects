using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 2.5);
        Rectangle rectangle = new Rectangle("blue", 5.5, 2.6);
        Circle circle = new Circle("green", 6.5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}