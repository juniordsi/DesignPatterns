using Decorator.Notifier;

// Base notifier
INotifier notifier = new EmailNotifier();

// Decorate with SMS and Slack notifications
notifier = new SmsDecorator(new SlackDecorator(notifier));

notifier.Send("Pattern example");
