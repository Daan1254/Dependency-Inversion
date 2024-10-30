namespace Solid_Principles.classes;

public class SMSNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("Sending SMS: " + message);
    }
}