using System;

namespace Mediator.Chat;

public abstract class User
{
    protected readonly IChatMediator Mediator;
    public string Name { get; }

    protected User(string name, IChatMediator mediator)
    {
        Name = name;
        Mediator = mediator;
        mediator.Register(this);
    }

    public void Send(string message)
    {
        Console.WriteLine($"{Name} sends: {message}");
        Mediator.SendMessage(message, this);
    }

    public abstract void Receive(string message);
}
