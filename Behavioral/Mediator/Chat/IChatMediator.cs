namespace Mediator.Chat;

public interface IChatMediator
{
    void SendMessage(string message, User user);
    void Register(User user);
}
