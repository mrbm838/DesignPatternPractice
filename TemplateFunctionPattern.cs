namespace DesignPattern;

public class TemplateFunctionPattern
{
    public static void Main(string[] args)
    {
        AbstractClass c;

        c = new ConcreteClassA();
        c.TemplateMethod();

        c = new ConcreteClassB();
        c.TemplateMethod();

        Console.ReadKey();
    }
}

abstract class AbstractClass
{
    public abstract void PrimitiveOperation1();
    public abstract void PrimitiveOperation2();

    public void TemplateMethod()
    {
        PrimitiveOperation1();
        PrimitiveOperation2();
    }
}

class ConcreteClassA : AbstractClass
{
    public override void PrimitiveOperation1()
    {
        System.Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
    }

    public override void PrimitiveOperation2()
    {
        System.Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
    }
}

class ConcreteClassB : AbstractClass
{
    public override void PrimitiveOperation1()
    {
        System.Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
    }

    public override void PrimitiveOperation2()
    {
        System.Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
    }
}
