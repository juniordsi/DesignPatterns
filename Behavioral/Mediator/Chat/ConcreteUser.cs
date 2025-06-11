using System;

namespace Mediator.Chat;

public class ConcreteUser : User
{
    public ConcreteUser(string name, IChatMediator mediator) : base(name, mediator)
    {
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"{Name} received: {message}");
    }
}
