namespace DesignPattern;

public class VisitorPattern
{
    public static void Main(string[] args)
    {
        ObjectStructure o = new ObjectStructure();
        o.Attach(new ConcreteElementA());
        o.Attach(new ConcreteElementB());

        ConcreteVisitor1 v1 = new ConcreteVisitor1();
        ConcreteVisitor2 v2 = new ConcreteVisitor2();

        o.Accept(v1);
        o.Accept(v2);
    }
}

abstract class Element
{
    public abstract void Accept(Visitor visitor);
}

class ConcreteElementA : Element
{
    public override void Accept(Visitor visitor)
    {
        visitor.VisitConcreteElementA(this);
    }

    public void OperationA()
    {
    }
}

class ConcreteElementB : Element
{
    public override void Accept(Visitor visitor)
    {
        visitor.VisitConcreteElementB(this);
    }

    public void OperationB()
    {
    }
}

abstract class Visitor
{
    public abstract void VisitConcreteElementA(ConcreteElementA elementA);
    public abstract void VisitConcreteElementB(ConcreteElementB elementB);
}

class ConcreteVisitor1 : Visitor
{
    public override void VisitConcreteElementA(ConcreteElementA elementA)
    {
        elementA.OperationA();
    }

    public override void VisitConcreteElementB(ConcreteElementB elementB)
    {
        elementB.OperationB();
    }
}

class ConcreteVisitor2 : Visitor
{
    public override void VisitConcreteElementA(ConcreteElementA elementA)
    {
        elementA.OperationA();
    }

    public override void VisitConcreteElementB(ConcreteElementB elementB)
    {
        elementB.OperationB();
    }
}

class ObjectStructure
{
    private List<Element> elements = new List<Element>();

    public void Attach(Element element)
    {
        elements.Add(element);
    }

    public void Detach(Element element)
    {
        elements.Remove(element);
    }

    public void Accept(Visitor visitor)
    {
        foreach (Element e in elements)
        {
            e.Accept(visitor);
        }
    }
}
