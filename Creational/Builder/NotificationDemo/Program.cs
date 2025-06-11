using Builder.NotificationDemo.Builders;
using Builder.NotificationDemo.Services;

namespace Builder.NotificationDemo;

class Program
{
    static void Main()
    {
        var email = new EmailBuilder()
            .From("noreply@example.com")
            .To("user@example.com")
            .Subject("Welcome")
            .Body("<p>Your account is ready.</p>")
            .AsHtml()
            .AddAttachment("terms.pdf")
            .Build();

        IEmailService service = new ConsoleEmailService();
        service.Send(email);
    }
}
