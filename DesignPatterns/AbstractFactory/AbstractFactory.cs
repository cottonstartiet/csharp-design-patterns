using System;

namespace DesignPatterns.AbstractFactory;

// Abstract Products
public interface IButton
{
    void Render();
}

public interface ICheckbox
{
    void Render();
}

// Concrete Products
public class WindowsButton : IButton
{
    public void Render() => Console.WriteLine("Rendering Windows Button");
}

public class MacButton : IButton
{
    public void Render() => Console.WriteLine("Rendering Mac Button");
}

public class WindowsCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Rendering Windows Checkbox");
}

public class MacCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Rendering Mac Checkbox");
}

// Abstract Factory Interface
public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}

// Concrete Factories
public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton() => new WindowsButton();
    public ICheckbox CreateCheckbox() => new WindowsCheckbox();
}

public class MacFactory : IGUIFactory
{
    public IButton CreateButton() => new MacButton();
    public ICheckbox CreateCheckbox() => new MacCheckbox();
}

// Client
public class Application
{
    private readonly IButton _button;
    private readonly ICheckbox _checkbox;

    public Application(IGUIFactory factory)
    {
        _button = factory.CreateButton();
        _checkbox = factory.CreateCheckbox();
    }

    public void Render()
    {
        _button.Render();
        _checkbox.Render();
    }
}

// Usage Example
public class AbstractFactoryDemo
{
    public static void Main()
    {
        IGUIFactory factory;

        if (OperatingSystem.IsWindows())
            factory = new WindowsFactory();
        else
            factory = new MacFactory();

        var app = new Application(factory);
        app.Render();
    }
}
