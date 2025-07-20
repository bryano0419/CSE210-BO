using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>
        {
            new Square("Red", 5),
            new Rectangle("Green", 4, 6),
            new Circle("Blue", 3)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}

