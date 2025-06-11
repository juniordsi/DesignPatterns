using System;

namespace Decorator.Notifier;

public class EmailNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending EMAIL: {message}");
    }
}
