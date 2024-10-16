using System;

public class Person
{
    private int age;
    public string Name { get; set; } 

    
    public Person(int age, string name)
    {
        this.age = age;
        this.Name = name;
    }

   
    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {age}");
    }
}
