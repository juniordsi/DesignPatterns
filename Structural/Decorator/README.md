# Decorator Design Pattern
Decorator is a structural pattern that lets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the behaviors.

## Intent
- Attach additional responsibilities to an object dynamically.
- Provide a flexible alternative to subclassing for extending functionality.

## Structure
```
Component < Interface >
   ^
 ConcreteComponent
   ^
 Decorator -- has a Component
   ^
 ConcreteDecoratorA
 ConcreteDecoratorB
```

### References
- https://refactoring.guru/design-patterns/decorator
