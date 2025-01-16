# Design Patterns App

This project demonstrates the implementation of various design patterns in C#. The following design patterns are included:

1. **Singleton Pattern**: Ensures a class has only one instance and provides a global point of access to it. The implementation can be found in `src/Patterns/Singleton.cs`.

2. **Factory Pattern**: Provides an interface for creating objects in a superclass but allows subclasses to alter the type of objects that will be created. The implementation can be found in `src/Patterns/Factory.cs`.

3. **Observer Pattern**: Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. The implementation can be found in `src/Patterns/Observer.cs`.

## Getting Started

To run the application, ensure you have the .NET SDK installed. You can clone the repository and navigate to the project directory:

```bash
git clone <repository-url>
cd design-patterns-app
```

Then, build and run the application:

```bash
dotnet run
```

## Usage

Each design pattern is demonstrated in the `src/Program.cs` file. You can modify the code to see how each pattern behaves and interacts with others.

## Contributing

Feel free to submit issues or pull requests if you have suggestions or improvements for the project.