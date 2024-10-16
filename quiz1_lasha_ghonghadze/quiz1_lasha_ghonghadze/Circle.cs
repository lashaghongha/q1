using System;

public class Circle : Shape
{
    private double radius;

   
    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

  
    public Circle(double radius)
    {
        this.Radius = radius;
        CalculateArea();
    }

    private void CalculateArea()
    {
        area = Math.PI * Radius * Radius;
    }

    public void DisplayArea()
    {
        Console.WriteLine($"Circle Area: {area}");
    }
}
