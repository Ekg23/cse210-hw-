using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {


        List<Shapes> shapes = new List<Shapes>();

        Sqaure s1 = new Sqaure("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        foreach (Shapes s in shapes)
        {
            string color = s.Getcolor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}