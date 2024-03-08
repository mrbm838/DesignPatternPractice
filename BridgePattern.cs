namespace DesignPattern;

public class BridgePattern
{
    public static void Main()
    {
        Abstraction ab = new RefinedAbstraction();

        ab.SetImplementor(new ConcreteImplementorA());
        ab.Operation();

        ab.SetImplementor(new ConcreteImplementorB());
        ab.Operation();
    }
}

abstract class Implementor
{
    public abstract void Operation();
}

class ConcreteImplementorA : Implementor
{
    public override void Operation()
    {
        Console.WriteLine("ConcreteImplementorA Operation");
    }
}

class ConcreteImplementorB : Implementor
{
    public override void Operation()
    {
        Console.WriteLine("ConcreteImplementorB Operation");
    }
}

abstract class Abstraction
{
    protected Implementor implementor;

    public void SetImplementor(Implementor implementor)
    {
        this.implementor = implementor;
    }

    public abstract void Operation();
}

class RefinedAbstraction : Abstraction
{
    public override void Operation()
    {
        implementor.Operation();
    }
}

