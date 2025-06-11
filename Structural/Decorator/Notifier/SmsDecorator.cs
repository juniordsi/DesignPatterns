using System;

namespace Decorator.Notifier;

public class SmsDecorator : NotifierDecorator
{
    public SmsDecorator(INotifier wrappee) : base(wrappee)
    {
    }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Sending SMS: {message}");
    }
}
