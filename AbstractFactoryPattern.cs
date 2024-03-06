namespace DesignPattern;

public class AbstractFactoryPattern
{
    public static void Main()
    {
        IAbstractFactory factory1 = new ConcreteFactory1();
        IAbstractProductA abstractProductA1 = factory1.CreateProductA();
        abstractProductA1.UsefulFunctionA();
        IAbstractProductB abstractProductB1 = factory1.CreateProductB();
        abstractProductB1.UsefulFunctionB();

        IAbstractFactory factory2 = new ConcreteFactory2();
        IAbstractProductA abstractProductA2 = factory2.CreateProductA();
        abstractProductA2.UsefulFunctionA();
        IAbstractProductB abstractProductB2 = factory2.CreateProductB();
        abstractProductB2.UsefulFunctionB();

        Console.ReadLine();
    }
}

interface IAbstractFactory
{
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}

class ConcreteFactory1 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ProductA1();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ProductB1();
    }
}

class ConcreteFactory2 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ProductA2();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ProductB2();
    }
}

interface IAbstractProductA
{
    string UsefulFunctionA();
}

class ProductA1 : IAbstractProductA
{
    public string UsefulFunctionA()
    {
        return "The result of the product A1.";
    }
}

class ProductA2 : IAbstractProductA
{
    public string UsefulFunctionA()
    {
        return "The result of the product A2.";
    }
}

interface IAbstractProductB
{
    string UsefulFunctionB();
}

class ProductB1 : IAbstractProductB
{
    public string UsefulFunctionB()
    {
        return "The result of the product B1.";
    }
}

class ProductB2 : IAbstractProductB
{
    public string UsefulFunctionB()
    {
        return "The result of the product B2.";
    }
}
