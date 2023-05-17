using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square S1 = new Square("Orange", 5);
        shapes.Add(S1);
        Circle C2 = new Circle("Blue", 4);
        shapes.Add(C2);
        Rectangle R3 = new Rectangle("Yellow", 3, 5);
        shapes.Add(R3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}