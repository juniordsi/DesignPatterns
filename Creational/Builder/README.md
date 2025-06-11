# Builder Design Pattern
Builder is a creational design pattern that lets you construct complex objects step by step. It enables the creation of different representations of an object using the same construction process.

## Intent
- Separate the construction of a complex object from its representation.
- Provide control over the building process so that the same steps can create different objects.

.NET uses the builder pattern in various libraries such as `ConfigurationBuilder` and `WebHostBuilder` which provide fluent methods for configuring and constructing objects.

### References
- https://refactoring.guru/design-patterns/builder
- https://learn.microsoft.com/dotnet/api/microsoft.extensions.configuration.configurationbuilder
