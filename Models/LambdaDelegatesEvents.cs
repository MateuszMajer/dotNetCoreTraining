using System;
using System.Threading;

namespace NET_Core_Training.Models
{

public class Events
{
    public delegate void UpdateStatus(string status);
    public event UpdateStatus StatusUpdated;
    
    public void StartUpdatingStatus()
    {
            if(StatusUpdated != null)
            {
                StatusUpdated($"status with ticks {DateTime.UtcNow.Ticks}");
            }
    }
}

 
public class FunctionalSandbox
{
    public void Test()
    { 
        var events = new Events();
        events.StatusUpdated += DisplayStatus;
        events.StartUpdatingStatus();
    }
 
    public void DisplayStatus(string status)
    {
        Console.WriteLine($"Received: {status}");
    }
}
}