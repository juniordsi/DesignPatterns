using System;

namespace Decorator.Notifier;

public class SlackDecorator : NotifierDecorator
{
    public SlackDecorator(INotifier wrappee) : base(wrappee)
    {
    }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Sending Slack message: {message}");
    }
}
