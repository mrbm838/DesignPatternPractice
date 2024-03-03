using System;


// Usage example
public class StrateygPattern
{
    public static void Main()
    {
        // Create the context with a specific strategy
        Context context = new Context(new ConcreteStrategyA());

        // Execute the strategy
        context.ExecuteStrategy();
    }
}

// Define the strategy interface
public interface IStrategy
{
    void Execute();
}

// Implement concrete strategies
public class ConcreteStrategyA : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Executing strategy A");
    }
}

public class ConcreteStrategyB : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Executing strategy B");
    }
}

// Define the context class
public class Context
{
    private IStrategy strategy;

    public Context(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void ExecuteStrategy()
    {
        strategy.Execute();
    }
}
