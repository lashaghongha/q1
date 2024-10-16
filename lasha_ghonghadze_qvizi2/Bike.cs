using System;

public class Bike : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started.");
    }

    public override void Accelerate()
    {
        Console.WriteLine("Bike is pedaling.");
    }
}

