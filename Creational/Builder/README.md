# Builder Design Pattern
Builder is a creational design pattern that lets you construct complex objects step by step. It enables creating different representations of an object using the same construction process.

## Intent
- Separate the construction of a complex object from its representation.
- Provide control over the building process so the same steps can create different objects.

.NET uses the builder pattern in libraries such as `ConfigurationBuilder` and `WebHostBuilder`, which expose fluent methods for configuring and constructing objects.

This demo shows an `EmailBuilder` that incrementally builds an `EmailMessage` object. The message can then be sent using a service implementation.

### References
- https://refactoring.guru/design-patterns/builder
- https://learn.microsoft.com/dotnet/api/microsoft.extensions.configuration.configurationbuilder
