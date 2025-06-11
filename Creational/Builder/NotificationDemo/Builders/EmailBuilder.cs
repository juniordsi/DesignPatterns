using Builder.NotificationDemo.Models;

namespace Builder.NotificationDemo.Builders;

public class EmailBuilder
{
    private string _from = string.Empty;
    private string _to = string.Empty;
    private string _subject = string.Empty;
    private string _body = string.Empty;
    private bool _isHtml;
    private readonly List<string> _attachments = new();

    public EmailBuilder From(string address)
    {
        _from = address;
        return this;
    }

    public EmailBuilder To(string address)
    {
        _to = address;
        return this;
    }

    public EmailBuilder Subject(string subject)
    {
        _subject = subject;
        return this;
    }

    public EmailBuilder Body(string body)
    {
        _body = body;
        return this;
    }

    public EmailBuilder AsHtml()
    {
        _isHtml = true;
        return this;
    }

    public EmailBuilder AddAttachment(string fileName)
    {
        _attachments.Add(fileName);
        return this;
    }

    public EmailMessage Build()
    {
        return new EmailMessage(_from, _to, _subject, _body, _isHtml, _attachments);
    }
}
