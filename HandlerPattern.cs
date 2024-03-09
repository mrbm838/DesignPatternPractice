namespace DesignPattern;

public class HandlerPattern
{
    public static void Main()
    {
        Handler h1 = new ConcreteHandlerA();
        Handler h2 = new ConcreteHandlerB();
        Handler h3 = new ConcreteHandlerC();

        h1.SetSuccessor(h2);
        h2.SetSuccessor(h3);

        int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

        foreach (int request in requests)
        {
            h1.HandleRequest(request);
        }
    }
}

abstract class Handler
{
    protected Handler successor;

    public void SetSuccessor(Handler successor)
    {
        this.successor = successor;
    }

    public abstract void HandleRequest(int request);
}

class ConcreteHandlerA : Handler
{
    public override void HandleRequest(int request)
    {
        if (request < 10)
        {
            Console.WriteLine("ConcreteHandlerA HandleRequest");
        }
        else
        {
            if (successor != null)
                successor.HandleRequest(request);
        }
    }
}

class ConcreteHandlerB : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 10 && request < 20)
        {
            Console.WriteLine("ConcreteHandlerB HandleRequest");
        }
        else
        {
            if (successor != null)
                successor.HandleRequest(request);
        }
    }
}

class ConcreteHandlerC : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 20)
        {
            Console.WriteLine("ConcreteHandlerC HandleRequest");
        }
        else
        {
            if (successor != null)
                successor.HandleRequest(request);
        }
    }
}
