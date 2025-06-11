using Builder.NotificationDemo.Models;

namespace Builder.NotificationDemo.Services;

public interface IEmailService
{
    void Send(EmailMessage message);
}
