using Mediator.Chat;

var mediator = new ChatMediator();
var alice = new ConcreteUser("Alice", mediator);
var bob = new ConcreteUser("Bob", mediator);

alice.Send("Hi Bob!");
bob.Send("Hello Alice!");
