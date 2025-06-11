using Builder.NotificationDemo.Models;

namespace Builder.NotificationDemo.Services;

public class ConsoleEmailService : IEmailService
{
    public void Send(EmailMessage message)
    {
        Console.WriteLine($"Sending email to {message.To}");
        Console.WriteLine($"Subject: {message.Subject}");
        Console.WriteLine($"Attachments: {message.Attachments.Count}");
    }
}
