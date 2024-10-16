using System;

public class Rectangle : Shape
{
    private double length;
    private double width;

   
    public double Length
    {
        get { return length; }
        set { length = value; }
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

   
    public Rectangle(double length, double width)
    {
        this.Length = length;
        this.Width = width;
        CalculateArea();
    }

    private void CalculateArea()
    {
        area = Length * Width;
    }

    public void DisplayArea()
    {
        Console.WriteLine($"Rectangle Area: {area}");
    }
}
