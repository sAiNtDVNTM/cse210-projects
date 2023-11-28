using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> sList = new List<Shape>();

        Square s1 = new Square("SkyBlue", 4);
        sList.Add(s1);

        Rectangle s2 = new Rectangle("Purple", 8, 5);
        sList.Add(s2);

        Circle s3 = new Circle("Yellow", 3);
        sList.Add(s3);

        foreach(Shape s in sList)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }

    }
}