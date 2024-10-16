using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Task 1:");
        Task1.ExecuteTask();
        Console.WriteLine();

        
        Console.WriteLine("Task 2:");
        Rectangle rect = new Rectangle(5.0, 7.0);
        Circle circ = new Circle(3.0);

        
        rect.DisplayArea();
        circ.DisplayArea();
        Console.WriteLine();

      
        Console.WriteLine("Task 3:");
        Person person = new Person(19, "lasha ghonghadze");
        person.PrintDetails();
    }
}
