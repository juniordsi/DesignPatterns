# Mediator Design Pattern
Mediator is a behavioral pattern that lets you reduce chaotic dependencies between objects. The pattern restricts direct communications between the objects and forces them to collaborate only via a mediator object.

## Intent
- Define an object that encapsulates how a set of objects interact.
- Promote loose coupling by keeping objects from referring to each other explicitly.

## Structure
```
Mediator < Interface >
   ^
 ConcreteMediator
   ^
 Colleague (abstract)
   ^
 ConcreteColleague1
 ConcreteColleague2
```

### References
- https://refactoring.guru/design-patterns/mediator
