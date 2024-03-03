namespace DesignMode;

public class FactoryFunctionPattern
{
    public static void Main()
    {
        Creator a = new ConcreteCreatorA();
        a.FactoryMethod().Operation();
        Creator b = new ConcreteCreatorB();
        b.FactoryMethod().Operation();
    }
}

public abstract class Product
{
    public abstract void Operation();
}

public class ConcreteProductA : Product
{
    public override void Operation()
    {
        Console.WriteLine("ConcreteProductA.Operation()");
    }
}

public class ConcreteProductB : Product
{
    public override void Operation()
    {
        Console.WriteLine("ConcreteProductB.Operation()");
    }
}

public abstract class Creator
{
    public abstract Product FactoryMethod();
}

public class ConcreteCreatorA : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProductA();
    }
}

public class ConcreteCreatorB : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProductB();
    }
}

