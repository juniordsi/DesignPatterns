using System.Collections.Generic;

namespace Mediator.Chat;

public class ChatMediator : IChatMediator
{
    private readonly List<User> _users = new();

    public void Register(User user)
    {
        if (!_users.Contains(user))
        {
            _users.Add(user);
        }
    }

    public void SendMessage(string message, User user)
    {
        foreach (var u in _users)
        {
            if (u != user)
            {
                u.Receive(message);
            }
        }
    }
}
