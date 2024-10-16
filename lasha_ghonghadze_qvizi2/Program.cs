using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        // Task 1: Generics and Data Handling
        DataHandler<int> handler = new DataHandler<int>();
        handler.AddData(10);
        handler.AddData(20);
        handler.AddData(30);

        Console.WriteLine("Retrieved Data: " + handler.RetrieveData(1));  

        // Task 2: Interfaces and Devices
        DeviceController tvController = new DeviceController("TV");
        tvController.Activate();  

        DeviceController phoneController = new DeviceController("Phone");
        phoneController.Activate();  

        // Task 3: Abstract Classes and Vehicles
        Car car = new Car();
        car.StartEngine();    
        car.Accelerate();     

        Bike bike = new Bike();
        bike.StartEngine();   
        bike.Accelerate();   
    }
}
