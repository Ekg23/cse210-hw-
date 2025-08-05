using System;
using System.Drawing;
using System.Formats.Asn1;

public  abstract class Shapes
{
    private string _color;

    public string Getcolor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    public Shapes(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
    
    
}

