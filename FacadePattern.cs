namespace DesignPattern;

public class FacadePattern
{
    public static void Main()
    {
        Facade facade = new();
        facade.FuncA();
        facade.FuncB();

        Console.ReadLine();
    }
}

abstract class SubSystem
{
    public abstract void Method();
}

class SubSystemOne : SubSystem
{
    public override void Method()
    {
        Console.WriteLine("sub1");
    }
}

class SubSystemTwo : SubSystem
{
    public override void Method()
    {
        Console.WriteLine("sub2");
    }
}

class SubSystemThree : SubSystem
{
    public override void Method()
    {
        Console.WriteLine("sub3");
    }
}

class Facade
{
    SubSystem _one;
    SubSystem _two;
    SubSystem _three;

    public Facade()
    {
        _one = new SubSystemOne();
        _two = new SubSystemTwo();
        _three = new SubSystemThree();
    }

    public void FuncA()
    {
        System.Console.WriteLine("A_______");
        _one.Method();
        _two.Method();
    }

    public void FuncB()
    {
        System.Console.WriteLine("B_______");
        _two.Method();
        _three.Method();
    }
}