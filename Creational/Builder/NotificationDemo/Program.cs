using System;

namespace Builder.NotificationDemo;

public record Notification(string Title, string Recipient, string Message, bool IsUrgent);

public class NotificationBuilder
{
    private string _title = string.Empty;
    private string _recipient = string.Empty;
    private string _message = string.Empty;
    private bool _urgent;

    public NotificationBuilder SetTitle(string title)
    {
        _title = title;
        return this;
    }

    public NotificationBuilder SetRecipient(string recipient)
    {
        _recipient = recipient;
        return this;
    }

    public NotificationBuilder SetMessage(string message)
    {
        _message = message;
        return this;
    }

    public NotificationBuilder MarkAsUrgent()
    {
        _urgent = true;
        return this;
    }

    public Notification Build()
    {
        return new Notification(_title, _recipient, _message, _urgent);
    }
}

class Program
{
    static void Main()
    {
        var notification = new NotificationBuilder()
            .SetTitle("Account Activated")
            .SetRecipient("user@example.com")
            .SetMessage("Your account is ready to use.")
            .MarkAsUrgent()
            .Build();

        Console.WriteLine($"To: {notification.Recipient} - {notification.Title} - Urgent: {notification.IsUrgent}");
    }
}
