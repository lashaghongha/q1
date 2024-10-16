using System;

public class DeviceController : IDevice
{
    private string deviceType;

   
    public DeviceController(string type)
    {
        deviceType = type;
    }

    public void Activate()
    {
        Console.WriteLine($"The {deviceType} is now active.");
    }
}
