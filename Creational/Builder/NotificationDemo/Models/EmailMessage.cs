namespace Builder.NotificationDemo.Models;

public class EmailMessage
{
    public string From { get; }
    public string To { get; }
    public string Subject { get; }
    public string Body { get; }
    public bool IsHtml { get; }
    public IReadOnlyList<string> Attachments { get; }

    public EmailMessage(string from, string to, string subject, string body, bool isHtml, IEnumerable<string> attachments)
    {
        From = from;
        To = to;
        Subject = subject;
        Body = body;
        IsHtml = isHtml;
        Attachments = attachments.ToList();
    }
}
