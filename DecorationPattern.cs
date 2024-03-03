namespace DesignMode;

public class DecoratorPattern
{
    public static void Main()
    {
        ConcreteComponent c = new ConcreteComponent();
        ConcreteDecoratorA d1 = new ConcreteDecoratorA();
        ConcreteDecoratorB d2 = new ConcreteDecoratorB();
        d1.SetComponent(c);
        d2.SetComponent(d1);
        d2.Operation();
    }
}

public abstract class Component
{
    public abstract void Operation();
}

public class ConcreteComponent : Component
{
    public override void Operation()
    {
        Console.WriteLine("ConcreteComponent.Operation()");
    }
}

public class Decorator : Component
{
    protected Component? component;
    public void SetComponent(Component component)
    {
        this.component = component;
    }
    public override void Operation()
    {
        if (component != null)
        {
            component.Operation();
        }
    }
}

public class ConcreteDecoratorA : Decorator
{
    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("ConcreteDecoratorA.Operation()");
    }
}

public class ConcreteDecoratorB : Decorator
{
    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("ConcreteDecoratorB.Operation()");
    }
}

