namespace DesignPattern;

public class BuilderPattern
{
    public static void Main()
    {
        Builder builderA = new ConcreteBuilderA();
        Director directorA = new(builderA);

        directorA.Construct();
        Product productA = builderA.GetProduct();
        productA.Show();

        Console.ReadLine();
    }
}

abstract class Builder
{
    public abstract void BuildPartA();
    public abstract void BuildPartB();
    public abstract void BuildPartC();
    public abstract Product GetProduct();
}

class ConcreteBuilderA : Builder
{
    Product _product = new();

    public override void BuildPartA()
    {
        _product.Add("A_______");
    }

    public override void BuildPartB()
    {
        _product.Add("B_______");
    }

    public override void BuildPartC()
    {
        _product.Add("C_______");
    }

    public override Product GetProduct()
    {
        return _product;
    }
}

class ConcreteBuilderB : Builder
{

    Product _product = new();

    public override void BuildPartA()
    {
        _product.Add("D_______");
    }

    public override void BuildPartB()
    {
        _product.Add("E_______");
    }

    public override void BuildPartC()
    {
        _product.Add("F_______");
    }

    public override Product GetProduct()
    {
        return _product;
    }
}

class Director
{
    Builder _builder;

    public Director(Builder builder)
    {
        _builder = builder;
    }

    public void Construct()
    {
        _builder.BuildPartA();
        _builder.BuildPartB();
        _builder.BuildPartC();
    }
}

class Product
{
    List<string> _parts = new();

    public void Add(string part)
    {
        _parts.Add(part);
    }

    public void Show()
    {
        foreach (var part in _parts)
        {
            System.Console.WriteLine(part);
        }
    }
}

